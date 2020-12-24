using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using BorderlessGaming.Logic.Core;
using BorderlessGaming.Logic.Extensions;
using BorderlessGaming.Logic.Models;
using BorderlessGaming.Logic.Steam;
using BorderlessGaming.Logic.System;
using BorderlessGaming.Logic.Windows;
using BorderlessGaming.Properties;

namespace BorderlessGaming.Forms
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            _watcher = new ProcessWatcher(this);
            InitializeComponent();
            LanguageManager.Setup(toolStripLanguages);
        }

        public void AddFavoriteToList(Favorite fav)
        {
            lstFavorites.Items.Add(fav);
        }

        public void RemoveFavoriteFromList(Favorite fav)
        {
            lstFavorites.Items.Remove(fav);
        }

        private void toolStripCheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.CheckForUpdates = toolStripCheckForUpdates.Checked;
            Config.Save();
        }

        #region Local data

        /// <summary>
        ///     The Borderless Toggle hotKey
        /// </summary>
        private const int MakeBorderlessHotKey = (int) Keys.F6;

        /// <summary>
        ///     The Borderless Toggle hotKey modifier
        /// </summary>
        private const int MakeBorderlessHotKeyModifier = 0x008; // WIN-Key

        /// <summary>
        ///     The Mouse Lock hotKey
        /// </summary>
        private const int MouseLockHotKey = (int) Keys.Scroll;

        /// <summary>
        ///     The Mouse Hide hotkey
        /// </summary>
        private const int MouseHideHotKey = (int) Keys.Scroll;

        /// <summary>
        ///     The Mouse Hide hotkey modifier
        /// </summary>
        private const int MouseHideHotKeyModifier = 0x008; // WIN-Key

        #endregion

        #region External access and processing

        #endregion


        #region Application Menu Events

        private void toolStripRunOnStartup_CheckChanged(object sender, EventArgs e)
        {
            AutoStart.Setup(toolStripRunOnStartup.Checked, "--silent --minimize");
            Config.Instance.AppSettings.RunOnStartup = toolStripRunOnStartup.Checked;
            Config.Save();
        }

        private void toolStripGlobalHotkey_CheckChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.UseGlobalHotkey = toolStripGlobalHotkey.Checked;
            Config.Save();
            RegisterHotkeys();
        }

        private void toolStripMouseLock_CheckChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.UseMouseLockHotkey = toolStripMouseLock.Checked;
            Config.Save();
            RegisterHotkeys();
        }

        private void useMouseHideHotkeyWinScrollLockToolStripMenuItem_CheckChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.UseMouseHideHotkey = toolStripMouseHide.Checked;
            Config.Save();
            RegisterHotkeys();
        }

        private void startMinimizedToTrayToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.StartMinimized = toolStripMinimizedToTray.Checked;
            Config.Save();
        }

        private void hideBalloonTipsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.HideBalloonTips = toolStripHideBalloonTips.Checked;
            Config.Save();
        }

        private void closeToTrayToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.CloseToTray = toolStripCloseToTray.Checked;
            Config.Save();
        }

        private void useSlowerWindowDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.SlowWindowDetection = toolStripSlowWindowDetection.Checked;
            Config.Save();
        }

        private async void viewFullProcessDetailsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)

        {
            Config.Instance.AppSettings.ViewAllProcessDetails = toolStripViewFullProcessDetails.Checked;
            Config.Save();
            await RefreshProcesses();
        }

        private async void resetHiddenProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Config.Instance.ResetHiddenProcesses();
            await RefreshProcesses();
        }

        private void openDataFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                    (
                        "explorer.exe",
                        "/e,\"" + AppEnvironment.DataPath + "\",\"" + AppEnvironment.DataPath + "\"")
                );
            }
            catch
            {
                // ignored
            }
        }

        private void pauseAutomaticProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _watcher.AutoHandleFavorites = false;
        }

        private void toggleMouseCursorVisibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manipulation.MouseCursorIsHidden ||
                MessageBox.Show(
                    LanguageManager.Data("toggleMouseCursorVisibilityPrompt"),
                    LanguageManager.Data("toggleMouseCursorVisibilityTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Manipulation.ToggleMouseCursorVisibility(this);
            }
        }

        private void toggleWindowsTaskbarVisibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manipulation.ToggleWindowsTaskbarVisibility();
        }

        private void toolStripReportBug_Click(object sender, EventArgs e)
        {
            Tools.GotoSite("https://github.com/Codeusa/Borderless-Gaming/issues");
        }

        private void toolStripSupportUs_Click(object sender, EventArgs e)
        {
            Tools.GotoSite("http://store.steampowered.com/app/388080");
        }

        private void toolStripRegexReference_Click(object sender, EventArgs e)
        {
            Tools.GotoSite("www.regular-expressions.info/reference.html");
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private async void fullApplicationRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RefreshProcesses();
        }

        private void HandleProcessChange(ProcessDetails process, bool remove)
        {
            if (process == null)
            {
                return;
            }
            if (remove)
            {
                this.PerformSafely(() => lstProcesses.Items.Remove(process));
            }
            else
            {
                this.PerformSafely(() => lstProcesses.Items.Add(process));
            }
            this.PerformSafely(() => statusLabel.Text = $@"{LanguageManager.Data("moreOptionsLabel")} {DateTime.Now}");
        }

        private async Task RefreshProcesses()
        {
            //clear the process list and repopulate it
            lstProcesses.Items.Clear();
            await _watcher.Refresh();
        }
        private void rainwayToolStrip_Click(object sender, EventArgs e)
        {
            Tools.GotoSite("https://rainway.io/?ref=borderlessgaming");
        }

        private void usageGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.GotoSite("http://steamcommunity.com/app/388080/discussions/0/535151589899658778/");
        }

        #endregion

        #region Application Form Events

        private void lstProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var validSelection = false;

            if (lstProcesses.SelectedItem != null)
            {
                var pd = (ProcessDetails) lstProcesses.SelectedItem;

                validSelection = pd.Manageable;
            }

            btnMakeBorderless.Enabled = btnRestoreWindow.Enabled = addSelectedItem.Enabled = validSelection;
        }

        private void lstFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveFavorite.Enabled = lstFavorites.SelectedItem != null;
        }

        private void setWindowTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }

            Native.SetWindowText(pd.WindowHandle,
                InputText(LanguageManager.Data("setWindowTitleTitle"), LanguageManager.Data("setWindowTitlePrompt"),
                    Native.GetWindowTitle(pd.WindowHandle)));
        }

        private async void hideThisProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }

            Config.Instance.ExcludeProcess(pd.BinaryName.Trim().ToLower());
            await RefreshProcesses();
        }

        /// <summary>
        ///     Makes the currently selected process borderless
        /// </summary>
        private async void btnMakeBorderless_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }

            await _watcher.RemoveBorder(pd);
        }

        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }

            Manipulation.RestoreWindow(pd);
        }

        /// <summary>
        ///     adds the currently selected process to the favorites (by window title text)
        /// </summary>
        private void byTheWindowTitleTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }
            var favorite = new Favorite
            {
                Type = FavoriteType.Title,
                SearchText = pd.WindowTitle
            };
            Config.Instance.AddFavorite(favorite, () =>
            {
                lstFavorites.Items.Add(favorite);
            });

        }

        /// <summary>
        ///     adds the currently selected process to the favorites (by process binary name)
        /// </summary>
        private void byTheProcessBinaryNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }
          var favorite = new Favorite
          {
              Type = FavoriteType.Process,
              SearchText = pd.BinaryName
          };
            Config.Instance.AddFavorite(favorite, () =>
            {
                lstFavorites.Items.Add(favorite);
            });
        }

        /// <summary>
        ///     adds the currently selected process to the favorites (by window title text)
        /// </summary>
        private void byTheWindowTitleTextregexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }
            var res = InputText("Add to favorites by RegEx string",
                "Regex string (see the Help menu for reference)", pd.WindowTitle);
            if (!string.IsNullOrWhiteSpace(res.Trim()))
            {
                var favorite = new Favorite
                {
                    Type = FavoriteType.Regex,
                    SearchText = res
                };
                Config.Instance.AddFavorite(favorite, () =>
                {
                    lstFavorites.Items.Add(favorite);
                });
            }
        }
        private string InputText(string sTitle, string sInstructions, string sDefaultValue = "")
        {
            try
            {
                using (var inputForm = new InputText())
                {
                    inputForm.Title = sTitle;
                    inputForm.Instructions = sInstructions;
                    inputForm.Input = sDefaultValue;

                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        return inputForm.Input;
                    }

                    return sDefaultValue;
                }
            }
            catch
            {
                // ignored
            }

            return string.Empty;
        }
        private void addSelectedItem_Click(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                return;
            }

            if (!string.IsNullOrEmpty(pd.WindowTitle))
            {
                byTheWindowTitleTextToolStripMenuItem_Click(sender, e);
            }
            else
            {
                byTheProcessBinaryNameToolStripMenuItem_Click(sender, e);
            }
        }

        private void RefreshFavoritesList(Favorite fav)
        {
            //refreshing is done through observables so this method just readds the favorite
            //to make it look like it updated and because i dont want to change all that code
            Config.Instance.AddFavorite(fav, () =>
            {
                lstFavorites.Items.Add(fav);
            });
        }

        /// <summary>
        ///     removes the currently selected entry from the favorites
        /// </summary>
        private void btnRemoveFavorite_Click(object sender, EventArgs e)
        {
            if (lstFavorites.SelectedItem == null)
            {
                return;
            }
            var fav = (Favorite) lstFavorites.SelectedItem;
            Config.Instance.RemoveFavorite(fav, () =>
            {
              lstFavorites.Items.Remove(fav);
            });
        }

        private void removeMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstFavorites.SelectedItem == null)
            {
                return;
            }

            var fav = (Favorite) lstFavorites.SelectedItem;

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });
            fav.RemoveMenus = toolStripRemoveMenus.Checked;
            RefreshFavoritesList(fav);
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstFavorites.SelectedItem == null)
            {
                return;
            }

            var fav = (Favorite) lstFavorites.SelectedItem;
            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });
            fav.TopMost = toolStripAlwaysOnTop.Checked;
            RefreshFavoritesList(fav);
        }

        private void adjustWindowBoundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });
            int.TryParse(
InputText(LanguageManager.Data("adjustWindowBoundsTitle"),
string.Format(LanguageManager.Data("adjustWindowBoundsPrompt"), LanguageManager.Data("adjustWindowBoundsLeft")), fav.OffsetL.ToString()),
out int favOffsetL);
            int.TryParse(
               InputText(LanguageManager.Data("adjustWindowBoundsTitle"),
                   string.Format(LanguageManager.Data("adjustWindowBoundsPrompt"), LanguageManager.Data("adjustWindowBoundsRight")), fav.OffsetR.ToString()),
                out int favOffsetR);
            int.TryParse(
                InputText(LanguageManager.Data("adjustWindowBoundsTitle"),
                    string.Format(LanguageManager.Data("adjustWindowBoundsPrompt"), LanguageManager.Data("adjustWindowBoundsTop")), fav.OffsetT.ToString()),
                out int favOffsetT);
            int.TryParse(
                InputText(LanguageManager.Data("adjustWindowBoundsTitle"),
                    string.Format(LanguageManager.Data("adjustWindowBoundsPrompt"), LanguageManager.Data("adjustWindowBoundsBottom")), fav.OffsetB.ToString()),
                out int favOffsetB);

            fav.OffsetL = favOffsetL;
            fav.OffsetR = favOffsetR;
            fav.OffsetT = favOffsetT;
            fav.OffsetB = favOffsetB;

            RefreshFavoritesList(fav);
        }

        private void automaximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });

            fav.ShouldMaximize = toolStripAutomaximize.Checked;

            if (fav.ShouldMaximize)
            {
                fav.Size = FavoriteSize.FullScreen;
                fav.PositionX = 0;
                fav.PositionY = 0;
                fav.PositionW = 0;
                fav.PositionH = 0;
            }

            RefreshFavoritesList(fav);
        }

        private void hideMouseCursorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;
            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });
            fav.HideMouseCursor = toolStripHideMouseCursor.Checked;
            RefreshFavoritesList(fav);
        }

        private void hideWindowsTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;
            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });

            fav.HideWindowsTaskbar = toolStripHideWindowsTaskbar.Checked;

            RefreshFavoritesList(fav);
        }

        private void setWindowSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;


            var result =
                MessageBox.Show(
                   LanguageManager.Data("setWindowSizeMousePrompt"),
                   LanguageManager.Data("setWindowSizeMouseTitle"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (result == DialogResult.Yes)
            {
                using (var frmSelectArea = new DesktopAreaSelector())
                {
                    if (frmSelectArea.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    // Temporarily disable compiler warning CS1690: http://msdn.microsoft.com/en-us/library/x524dkh4.aspx
                    //
                    // We know what we're doing: everything is safe here.
#pragma warning disable 1690
                    fav.PositionX = frmSelectArea.CurrentTopLeft.X;
                    fav.PositionY = frmSelectArea.CurrentTopLeft.Y;
                    fav.PositionW = frmSelectArea.CurrentBottomRight.X - frmSelectArea.CurrentTopLeft.X;
                    fav.PositionH = frmSelectArea.CurrentBottomRight.Y - frmSelectArea.CurrentTopLeft.Y;
#pragma warning restore 1690
                }
            }
            else // System.Windows.Forms.DialogResult.No
            {
                int.TryParse(
InputText(LanguageManager.Data("setWindowSizeTitle"), string.Format(LanguageManager.Data("setWindowSizePixelPrompt"), "X"),
fav.PositionX.ToString()), out int favPositionX);
                int.TryParse(
                   InputText(LanguageManager.Data("setWindowSizeTitle"), string.Format(LanguageManager.Data("setWindowSizePixelPrompt"), "Y"),
                        fav.PositionY.ToString()), out int favPositionY);
                int.TryParse(InputText(LanguageManager.Data("setWindowSizeTitle"), LanguageManager.Data("setWindowSizeWidthPrompt"), fav.PositionW.ToString()),
                    out int favPositionW);
                int.TryParse(
                    InputText(LanguageManager.Data("setWindowSizeTitle"), LanguageManager.Data("setWindowSizeHeightPrompt"), fav.PositionH.ToString()),
                    out int favPositionH);
                fav.PositionX = favPositionX;
                fav.PositionH = favPositionH;
                fav.PositionW = favPositionW;
                fav.PositionY = favPositionY;
            }

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });

            if (fav.PositionW == 0 || fav.PositionH == 0)
            {
                fav.Size = FavoriteSize.FullScreen;
            }
            else
            {
                fav.Size = FavoriteSize.SpecificSize;
                fav.ShouldMaximize = false;
            }
            RefreshFavoritesList(fav);
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });


            fav.Size = toolStripFullScreen.Checked ? FavoriteSize.FullScreen : FavoriteSize.NoChange;

            if (fav.Size == FavoriteSize.FullScreen)
            {
                fav.PositionX = 0;
                fav.PositionY = 0;
                fav.PositionW = 0;
                fav.PositionH = 0;
            }
            else
            {
                fav.ShouldMaximize = false;
            }

            RefreshFavoritesList(fav);
        }


        private void noSizeChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });

            fav.Size = toolStripNoSizeChange.Checked ? FavoriteSize.NoChange : FavoriteSize.FullScreen;

            if (fav.Size == FavoriteSize.NoChange)
            {
                fav.ShouldMaximize = false;
                fav.OffsetL = 0;
                fav.OffsetR = 0;
                fav.OffsetT = 0;
                fav.OffsetB = 0;
                fav.PositionX = 0;
                fav.PositionY = 0;
                fav.PositionW = 0;
                fav.PositionH = 0;
            }

            RefreshFavoritesList(fav);
        }

        private void delayBorderlessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fav = (Favorite) lstFavorites.SelectedItem;

            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });

            fav.DelayBorderless = toolStripDelayBorderless.Checked;
            RefreshFavoritesList(fav);
        }

        private void toolStripForceResize_Click(object sender, EventArgs e)
        {
            _watcher.ResetMadeBorderless((Favorite) lstFavorites.SelectedItem);
        }

        /// <summary>
        ///     Sets up the Favorite-ContextMenu according to the current state
        /// </summary>
        private void mnuFavoritesContext_Opening(object sender, CancelEventArgs e)
        {
            if (lstFavorites.SelectedItem == null)
            {
                e.Cancel = true;
                return;
            }

            var fav = (Favorite) lstFavorites.SelectedItem;
            toolStripFullScreen.Checked = fav.Size == FavoriteSize.FullScreen;

            toolStripMuteInBackground.Checked = fav.MuteInBackground;
            toolStripAutomaximize.Checked = fav.ShouldMaximize;
            toolStripAlwaysOnTop.Checked = fav.TopMost;
            toolStripHideMouseCursor.Checked = fav.HideMouseCursor;
            toolStripHideWindowsTaskbar.Checked = fav.HideWindowsTaskbar;
            toolStripRemoveMenus.Checked = fav.RemoveMenus;

            toolStripAutomaximize.Enabled = fav.Size == FavoriteSize.FullScreen;
            toolStripAdjustWindowBounds.Enabled = fav.Size == FavoriteSize.FullScreen && !fav.ShouldMaximize;
            toolStripSetSetWindowSize.Enabled = fav.Size != FavoriteSize.FullScreen;
            toolStripSetSetWindowSize.Checked = fav.Size == FavoriteSize.SpecificSize;
            toolStripNoSizeChange.Checked = fav.Size == FavoriteSize.NoChange;

            if (Screen.AllScreens.Length < 2)
            {
                contextFavScreen.Visible = false;
            }
            else
            {
                contextFavScreen.Visible = true;

                if (contextFavScreen.HasDropDownItems)
                {
                    contextFavScreen.DropDownItems.Clear();
                }

                var superSize = Screen.PrimaryScreen.Bounds;

                foreach (var screen in Screen.AllScreens)
                {
                    superSize = Tools.GetContainingRectangle(superSize, screen.Bounds);

                    // fix for a .net-bug on Windows XP
                    var idx = screen.DeviceName.IndexOf('\0');
                    var fixedDeviceName = idx > 0 ? screen.DeviceName.Substring(0, idx) : screen.DeviceName;

                    var label = fixedDeviceName + (screen.Primary ? " (P)" : string.Empty);
                    var index = contextFavScreen.DropDownItems.Add(new ToolStripMenuItem
                    {
                        Text =  label,
                        CheckOnClick = true,
                        Checked = fav.FavScreen?.Equals(PRectangle.ToPRectangle(screen.Bounds)) ?? false
                    });
                    contextFavScreen.DropDownItems[index].Click += (s, ea) =>
                    {
                        var tt = (ToolStripMenuItem)s;
                        fav.FavScreen = tt.Checked ? PRectangle.ToPRectangle(screen.Bounds) : new PRectangle();
                        Config.Save();
                    };
                }
                // add supersize Option
                var superIndex = contextFavScreen.DropDownItems.Add(new ToolStripMenuItem
                {
                    Text = LanguageManager.Data("superSize"),
                    CheckOnClick = true,
                    Checked = fav.FavScreen?.Equals(PRectangle.ToPRectangle(superSize)) ?? false
                });
                contextFavScreen.DropDownItems[superIndex].Click += (s, ea) =>
                {
                    fav.FavScreen = PRectangle.ToPRectangle(superSize);
                    Config.Save();
                };
            }
        }

        /// <summary>
        ///     Sets up the Process-ContextMenu according to the current state
        /// </summary>
        private void processContext_Opening(object sender, CancelEventArgs e)
        {
            if (lstProcesses.SelectedItem == null)
            {
                e.Cancel = true;
                return;
            }

            var pd = (ProcessDetails) lstProcesses.SelectedItem;

            if (!pd.Manageable)
            {
                e.Cancel = true;
                return;
            }

            contextAddToFavs.Enabled = Config.Instance.CanAddFavorite(pd.BinaryName) &&
                                       Config.Instance.CanAddFavorite(pd.WindowTitle);

            if (Screen.AllScreens.Length < 2)
            {
                contextBorderlessOn.Visible = false;
            }
            else
            {
                contextBorderlessOn.Visible = true;

                if (contextBorderlessOn.HasDropDownItems)
                {
                    contextBorderlessOn.DropDownItems.Clear();
                }

                var superSize = Screen.PrimaryScreen.Bounds;

                foreach (var screen in Screen.AllScreens)
                {
                    superSize = Tools.GetContainingRectangle(superSize, screen.Bounds);

                    // fix for a .net-bug on Windows XP
                    var idx = screen.DeviceName.IndexOf('\0');
                    var fixedDeviceName = idx > 0 ? screen.DeviceName.Substring(0, idx) : screen.DeviceName;

                    var label = fixedDeviceName + (screen.Primary ? " (P)" : string.Empty);

                    var tsi = new ToolStripMenuItem(label);
                    tsi.Click += async (s, ea) => { await _watcher.RemoveBorder_ToSpecificScreen(pd, screen); };

                    contextBorderlessOn.DropDownItems.Add(tsi);
                }

                // add supersize Option
                var superSizeItem = new ToolStripMenuItem(LanguageManager.Data("superSize"));

                superSizeItem.Click += async (s, ea) => { await _watcher.RemoveBorder_ToSpecificRect(pd, superSize); };

                contextBorderlessOn.DropDownItems.Add(superSizeItem);
            }
        }

        private ToolStripMenuItem _toolStripDisableSteamIntegration;

        /// <summary>
        ///     Sets up the form
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // set the title
            Text = "Borderless Gaming " + Assembly.GetExecutingAssembly().GetName().Version.ToString(3) + ((Uac.Elevated) ? " [Administrator]" : "");

            var settings = Config.Instance.AppSettings;
            // load up settings
            toolStripRunOnStartup.Checked = settings.RunOnStartup;
            toolStripGlobalHotkey.Checked = settings.UseGlobalHotkey;
            toolStripCheckForUpdates.Checked = settings.CheckForUpdates;
            toolStripMouseLock.Checked = settings.UseMouseLockHotkey;
            toolStripMouseHide.Checked = settings.UseMouseHideHotkey;
            toolStripMinimizedToTray.Checked = settings.StartMinimized;
            toolStripHideBalloonTips.Checked = settings.HideBalloonTips;
            toolStripCloseToTray.Checked = settings.CloseToTray;
            toolStripViewFullProcessDetails.Checked = settings.ViewAllProcessDetails;
            toolStripSlowWindowDetection.Checked = settings.SlowWindowDetection;

            // minimize the window if desired (hiding done in Shown)
            if (settings.StartMinimized || Config.Instance.StartupOptions.Minimize)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

            if (SteamApi.IsLoaded && _toolStripDisableSteamIntegration == null)
            {
                _toolStripDisableSteamIntegration =
                    new ToolStripMenuItem
                    {
                        Name = "toolStripDisableSteamIntegration",
                        Size = new Size(254, 22),
                        Text = LanguageManager.Data("toolStripDisableSteamIntegration"),
                        ToolTipText = LanguageManager.Data("steamHint"),
                        Checked = settings.DisableSteamIntegration,
                        CheckOnClick = true
                    };
                // let's do this before registering the CheckedChanged event
                _toolStripDisableSteamIntegration.CheckedChanged +=
                    ToolStripDisableSteamIntegrationCheckChanged;
                toolsToolStripMenuItem.DropDownItems.Insert(0, _toolStripDisableSteamIntegration);
            }
        }

        private void ToolStripDisableSteamIntegrationCheckChanged(object sender, EventArgs e)
        {
            Config.Instance.AppSettings.DisableSteamIntegration = _toolStripDisableSteamIntegration.Checked;
            Config.Save();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            // hide the window if desired (this doesn't work well in Load)
            if (Config.Instance.AppSettings.StartMinimized || Config.Instance.StartupOptions.Minimize)
            {
                Hide();
            } else {
             //   if (Config.Instance.AppSettings.ShowAdOnStart)
               // {
                //    var rainway = new Rainway { StartPosition = this.StartPosition, TopMost = true };
                 //   rainway.ShowDialog(this);
                 //   rainway.BringToFront();

               // }
            }
            // initialize favorite list
            foreach (var ni in Config.Instance.Favorites)
            {
                lstFavorites.Items.Add(ni);
            }

            // start Task API controller
            _watcher.Start(HandleProcessChange);

            // Update buttons' enabled/disabled state
            lstProcesses_SelectedIndexChanged(sender, e);
            lstFavorites_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        ///     Cleans up when the application exits (main form closes)
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Not allowed to exit the application if we've hidden the Windows taskbar.
            //
            // Make them exit the game that triggered the taskbar to be hidden -- or -- use a global hotkey to restore it.
            if (Manipulation.WindowsTaskbarIsHidden)
            {
                _closingFromExitMenu = false;
                e.Cancel = true;
                return;
            }

            // If we're exiting -- or -- if we're closing-to-tray, then restore the mouse cursor.
            //
            // This prevents a scenario where the user can't (easily) get back to Borderless Gaming to undo the hidden mouse cursor.
            Manipulation.ToggleMouseCursorVisibility(this, Boolstate.True);

            // If the user didn't choose to exit from the tray icon context menu...
            if (!_closingFromExitMenu)
            {
                // ... and they have the preference set to close-to-tray ...
                if (Config.Instance.AppSettings.CloseToTray)
                {
                    // ... then minimize the app and do not exit (minimizing will trigger another event to hide the form)
                    WindowState = FormWindowState.Minimized;
                    e.Cancel = true;
                    return;
                }
            }

            // At this point, we're okay to exit the application

            // Unregister all global hotkeys
            UnregisterHotkeys();

            // Hide the tray icon.  If we don't do this, then Environment.Exit() can sometimes ghost the icon in the
            // Windows system tray area.
            trayIcon.Visible = false;

            // Overkill... the form should just close naturally.  Ideally we would just allow the form to close and
            // the remaining code in Program.cs would execute (if there were any), but this is how Borderless Gaming has
            // always exited and there may be a compatibility reason for it, so leaving it alone for now.
            Environment.Exit(0);
        }

        private void addSelectedItem_MouseHover(object sender, EventArgs e)
        {
            var ttTemp = new ToolTip();
            ttTemp.SetToolTip((Control) sender, LanguageManager.Data("addFavorite"));
        }

        private void btnRemoveFavorite_MouseHover(object sender, EventArgs e)
        {
            var ttTemp = new ToolTip();
            ttTemp.SetToolTip((Control) sender, LanguageManager.Data("removeFavorite"));
        }

        private void btnMakeBorderless_MouseHover(object sender, EventArgs e)
        {
            var ttTemp = new ToolTip();
            ttTemp.SetToolTip((Control) sender, LanguageManager.Data("makeBorderless"));
        }

        private void btnRestoreWindow_MouseHover(object sender, EventArgs e)
        {
            var ttTemp = new ToolTip();
            ttTemp.SetToolTip((Control) sender, LanguageManager.Data("restoreBorders"));
        }

        #endregion

        #region Tray Icon Events

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private bool _closingFromExitMenu;
        private readonly ProcessWatcher _watcher;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _closingFromExitMenu = true;
            Close();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;

                if (Config.Instance.AppSettings.HideBalloonTips && !Config.Instance.StartupOptions.Silent)
                {
                    // Display a balloon tooltip message for 2 seconds
                    trayIcon.BalloonTipText = string.Format(Resources.TrayMinimized, "Borderless Gaming");
                    trayIcon.ShowBalloonTip(2000);
                }

                if (!Manipulation.WindowsTaskbarIsHidden)
                {
                    Hide();
                }
            }
        }

        #endregion

        #region Global HotKeys

        /// <summary>
        ///     registers the global hotkeys
        /// </summary>
        private void RegisterHotkeys()
        {
            UnregisterHotkeys();

            if (Config.Instance.AppSettings.UseGlobalHotkey)
            {
                Native.RegisterHotKey(Handle, GetType().GetHashCode(), MakeBorderlessHotKeyModifier,
                    MakeBorderlessHotKey);
            }

            if (Config.Instance.AppSettings.UseMouseLockHotkey)
            {
                Native.RegisterHotKey(Handle, GetType().GetHashCode(), 0, MouseLockHotKey);
            }

            if (Config.Instance.AppSettings.UseMouseHideHotkey)
            {
                Native.RegisterHotKey(Handle, GetType().GetHashCode(), MouseHideHotKeyModifier, MouseHideHotKey);
            }
        }

        /// <summary>
        ///     unregisters the global hotkeys
        /// </summary>
        private void UnregisterHotkeys()
        {
            Native.UnregisterHotKey(Handle, GetType().GetHashCode());
        }

        /// <summary>
        ///     Catches the Hotkeys
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Native.WM_HOTKEY)
            {
                var keystroke = ((uint) m.LParam >> 16) & 0x0000FFFF;
                var keystrokeModifier = (uint) m.LParam & 0x0000FFFF;

                // Global hotkey to make a window borderless
                if (keystroke == MakeBorderlessHotKey && keystrokeModifier == MakeBorderlessHotKeyModifier)
                {
                    // Find the currently-active window
                    var hCurrentActiveWindow = Native.GetForegroundWindow();

                    // Only if that window isn't Borderless Windows itself
                    if (hCurrentActiveWindow != Handle)
                    {
                        // Figure out the process details based on the current window handle
                        var pd = _watcher.FromHandle(hCurrentActiveWindow);
                        if (pd == null)
                        {
                            Task.WaitAll(_watcher.Refresh());
                            pd = _watcher.FromHandle(hCurrentActiveWindow);
                            if (pd == null)
                            {
                                return;
                            }
                        }
                        // If we have information about this process -and- we've already made it borderless, then reverse the process
                        if (pd.MadeBorderless)
                        {
                            Manipulation.RestoreWindow(pd);
                        }
                        // Otherwise, this is a fresh request to remove the border from the current window
                        else
                        {
                             _watcher.RemoveBorder(pd).GetAwaiter().GetResult();
                        }
                    }

                    return; // handled the message, do not call base WndProc for this message
                }

                if (keystroke == MouseHideHotKey && keystrokeModifier == MouseHideHotKeyModifier)
                {
                    Manipulation.ToggleMouseCursorVisibility(this);

                    return; // handled the message, do not call base WndProc for this message
                }

                if (keystroke == MouseLockHotKey && keystrokeModifier == 0)
                {
                    var hWnd = Native.GetForegroundWindow();

                    // get size of clientarea
                    var rect = new Native.Rect();
                    Native.GetClientRect(hWnd, ref rect);

                    // get top,left point of clientarea
                    var p = new Native.POINTAPI {X = 0, Y = 0};
                    Native.ClientToScreen(hWnd, ref p);

                    var clipRect = new Rectangle(p.X, p.Y, rect.Right - rect.Left, rect.Bottom - rect.Top);

                    Cursor.Clip = Cursor.Clip.Equals(clipRect) ? Rectangle.Empty : clipRect;

                    return; // handled the message, do not call base WndProc for this message
                }
            }

            base.WndProc(ref m);
        }

        #endregion

        private void muteInBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            var fav = (Favorite)lstFavorites.SelectedItem;
            Config.Instance.RemoveFavorite(fav, () =>
            {
                lstFavorites.Items.Remove(fav);
            });
            fav.MuteInBackground = toolStripMuteInBackground.Checked;
            if (!fav.MuteInBackground)
            {
                if (fav.IsRunning && Native.IsMuted(fav.RunningId))
                {
                    Native.UnMuteProcess(fav.RunningId);
                }
            } else if (fav.MuteInBackground)
            {
                if (fav.IsRunning && !Native.IsMuted(fav.RunningId))
                {
                    Native.MuteProcess(fav.RunningId);
                }
            }
            RefreshFavoritesList(fav);
        }

        private void checkOutRainwayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.GotoSite("https://rainway.io/?ref=borderlessgaming3");
        }
    }
}