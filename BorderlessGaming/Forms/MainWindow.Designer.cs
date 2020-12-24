using BorderlessGaming.Logic.Core;
using BorderlessGaming.Properties;

namespace BorderlessGaming.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnMakeBorderless = new System.Windows.Forms.Button();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.processContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAddToFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByTheWindowTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripByProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.contextBorderlessOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetWindowTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHideProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFavScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.addSelectedItem = new System.Windows.Forms.Button();
            this.lstFavorites = new System.Windows.Forms.ListBox();
            this.mnuFavoritesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNoSizeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSetSetWindowSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAutomaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdjustWindowBounds = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelayBorderless = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripForceResize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideMouseCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideWindowsTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRemoveMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMuteInBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRemoveFromFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveFavorite = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.favoritesLabel = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGlobalHotkey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMouseLock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMouseHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMinimizedToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCloseToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHideBalloonTips = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSlowWindowDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripViewFullProcessDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRestoreProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPauseAutomaticProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOpenDataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripToggleMouseCursorVisibility = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripToggleWindowsTaskbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFullApplicationRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.rainwayStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsageGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegexReference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripReportBug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSupportUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestoreWindow = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.processContext.SuspendLayout();
            this.mnuFavoritesContext.SuspendLayout();
            this.trayIconContextMenu.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeBorderless
            // 
            resources.ApplyResources(this.btnMakeBorderless, "btnMakeBorderless");
            this.btnMakeBorderless.Image = global::BorderlessGaming.Properties.Resources.borderless;
            this.btnMakeBorderless.Name = "btnMakeBorderless";
            this.btnMakeBorderless.UseVisualStyleBackColor = true;
            this.btnMakeBorderless.Click += new System.EventHandler(this.btnMakeBorderless_Click);
            this.btnMakeBorderless.MouseHover += new System.EventHandler(this.btnMakeBorderless_MouseHover);
            // 
            // lstProcesses
            // 
            resources.ApplyResources(this.lstProcesses, "lstProcesses");
            this.lstProcesses.ContextMenuStrip = this.processContext;
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Sorted = true;
            this.lstProcesses.SelectedIndexChanged += new System.EventHandler(this.lstProcesses_SelectedIndexChanged);
            // 
            // processContext
            // 
            resources.ApplyResources(this.processContext, "processContext");
            this.processContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAddToFavs,
            this.toolStripMenuItem1,
            this.contextBorderless,
            this.contextBorderlessOn,
            this.toolStripSetWindowTitle,
            this.toolStripMenuItem8,
            this.toolStripHideProcess});
            this.processContext.Name = "processContext";
            this.processContext.Opening += new System.ComponentModel.CancelEventHandler(this.processContext_Opening);
            // 
            // contextAddToFavs
            // 
            resources.ApplyResources(this.contextAddToFavs, "contextAddToFavs");
            this.contextAddToFavs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripByTheWindowTitle,
            this.toolStripByRegex,
            this.toolStripByProcess});
            this.contextAddToFavs.Name = "contextAddToFavs";
            this.contextAddToFavs.Text = LanguageManager.Data("contextAddToFavs");
            // 
            // byTheWindowTitleTextToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripByTheWindowTitle, "toolStripByTheWindowTitle");
            this.toolStripByTheWindowTitle.Name = "toolStripByTheWindowTitle";
            this.toolStripByTheWindowTitle.Text = LanguageManager.Data("toolStripByTheWindowTitle");
            this.toolStripByTheWindowTitle.Click += new System.EventHandler(this.byTheWindowTitleTextToolStripMenuItem_Click);
            // 
            // byTheWindowTitleTextregexToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripByRegex, "toolStripByRegex");
            this.toolStripByRegex.Name = "toolStripByRegex";
            this.toolStripByRegex.Text = LanguageManager.Data("toolStripByRegex");
            this.toolStripByRegex.Click += new System.EventHandler(this.byTheWindowTitleTextregexToolStripMenuItem_Click);
            // 
            // byTheProcessBinaryNameToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripByProcess, "toolStripByProcess");
            this.toolStripByProcess.Name = "toolStripByProcess";
            this.toolStripByProcess.Text = LanguageManager.Data("toolStripByProcess");
            this.toolStripByProcess.Click += new System.EventHandler(this.byTheProcessBinaryNameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // contextBorderless
            // 
            resources.ApplyResources(this.contextBorderless, "contextBorderless");
            this.contextBorderless.Name = "contextBorderless";
            this.contextBorderless.Text = LanguageManager.Data("contextBorderless");
            this.contextBorderless.Click += new System.EventHandler(this.btnMakeBorderless_Click);
            // 
            // contextBorderlessOn
            // 
            resources.ApplyResources(this.contextBorderlessOn, "contextBorderlessOn");
            this.contextBorderlessOn.Name = "contextBorderlessOn";
            this.contextBorderlessOn.Text = LanguageManager.Data("contextBorderlessOn");
            // 
            // setWindowTitleToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripSetWindowTitle, "toolStripSetWindowTitle");
            this.toolStripSetWindowTitle.Name = "toolStripSetWindowTitle";
            this.toolStripSetWindowTitle.Text = LanguageManager.Data("toolStripSetWindowTitle");
            this.toolStripSetWindowTitle.Click += new System.EventHandler(this.setWindowTitleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            // 
            // hideThisProcessToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripHideProcess, "toolStripHideProcess");
            this.toolStripHideProcess.Name = "toolStripHideProcess";
            this.toolStripHideProcess.Text = LanguageManager.Data("toolStripHideProcess");
            this.toolStripHideProcess.Click += new System.EventHandler(this.hideThisProcessToolStripMenuItem_Click);
            // 
            // contextFavScreen
            // 
            resources.ApplyResources(this.contextFavScreen, "contextFavScreen");
            this.contextFavScreen.Text = LanguageManager.Data("contextFavScreen");
            this.contextFavScreen.Name = "contextFavScreen";
            // 
            // addSelectedItem
            // 
            resources.ApplyResources(this.addSelectedItem, "addSelectedItem");
            this.addSelectedItem.Image = global::BorderlessGaming.Properties.Resources.add;
            this.addSelectedItem.Name = "addSelectedItem";
            this.addSelectedItem.UseVisualStyleBackColor = true;
            this.addSelectedItem.Click += new System.EventHandler(this.addSelectedItem_Click);
            this.addSelectedItem.MouseHover += new System.EventHandler(this.addSelectedItem_MouseHover);
            // 
            // lstFavorites
            // 
            resources.ApplyResources(this.lstFavorites, "lstFavorites");
            this.lstFavorites.ContextMenuStrip = this.mnuFavoritesContext;
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Sorted = true;
            this.lstFavorites.SelectedIndexChanged += new System.EventHandler(this.lstFavorites_SelectedIndexChanged);
            // 
            // mnuFavoritesContext
            // 
            resources.ApplyResources(this.mnuFavoritesContext, "mnuFavoritesContext");
            this.mnuFavoritesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFullScreen,
            this.toolStripNoSizeChange,
            this.toolStripSetSetWindowSize,
            this.toolStripMenuItem6,
            this.toolStripAutomaximize,
            this.toolStripAdjustWindowBounds,
            this.toolStripMenuItem4,
            this.toolStripAlwaysOnTop,
            this.toolStripDelayBorderless,
            this.toolStripForceResize,
            this.toolStripHideMouseCursor,
            this.toolStripHideWindowsTaskbar,
            this.toolStripRemoveMenus,
            this.toolStripMenuItem9,
            this.contextFavScreen,
            this.toolStripMuteInBackground,
            this.contextRemoveFromFavs});
            this.mnuFavoritesContext.Name = "mnuFavoritesRightClick";
            this.mnuFavoritesContext.Opening += new System.ComponentModel.CancelEventHandler(this.mnuFavoritesContext_Opening);
            // 
            // fullScreenToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripFullScreen, "toolStripFullScreen");
            this.toolStripFullScreen.CheckOnClick = true;
            this.toolStripFullScreen.Name = "toolStripFullScreen";
            this.toolStripFullScreen.Text = LanguageManager.Data("toolStripFullScreen");
            this.toolStripFullScreen.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // noSizeChangeToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripNoSizeChange, "toolStripNoSizeChange");
            this.toolStripNoSizeChange.CheckOnClick = true;
            this.toolStripNoSizeChange.Name = "toolStripNoSizeChange";
            this.toolStripNoSizeChange.Text = LanguageManager.Data("toolStripNoSizeChange");
            this.toolStripNoSizeChange.Click += new System.EventHandler(this.noSizeChangeToolStripMenuItem_Click);
            // 
            // setWindowSizeToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripSetSetWindowSize, "toolStripSetSetWindowSize");
            this.toolStripSetSetWindowSize.Name = "toolStripSetSetWindowSize";
            this.toolStripSetSetWindowSize.Text = LanguageManager.Data("toolStripSetSetWindowSize");
            this.toolStripSetSetWindowSize.Click += new System.EventHandler(this.setWindowSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // automaximizeToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripAutomaximize, "toolStripAutomaximize");
            this.toolStripAutomaximize.CheckOnClick = true;
            this.toolStripAutomaximize.Name = "toolStripAutomaximize";
            this.toolStripAutomaximize.Text = LanguageManager.Data("toolStripAutomaximize");
            this.toolStripAutomaximize.Click += new System.EventHandler(this.automaximizeToolStripMenuItem_Click);
            // 
            // adjustWindowBoundsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripAdjustWindowBounds, "toolStripAdjustWindowBounds");
            this.toolStripAdjustWindowBounds.Name = "toolStripAdjustWindowBounds";
            this.toolStripAdjustWindowBounds.Text = LanguageManager.Data("toolStripAdjustWindowBounds");
            this.toolStripAdjustWindowBounds.Click += new System.EventHandler(this.adjustWindowBoundsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripAlwaysOnTop, "toolStripAlwaysOnTop");
            this.toolStripAlwaysOnTop.CheckOnClick = true;
            this.toolStripAlwaysOnTop.Name = "toolStripAlwaysOnTop";
            this.toolStripAlwaysOnTop.Text = LanguageManager.Data("toolStripAlwaysOnTop");
            this.toolStripAlwaysOnTop.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // delayBorderlessToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripDelayBorderless, "toolStripDelayBorderless");
            this.toolStripDelayBorderless.CheckOnClick = true;
            this.toolStripDelayBorderless.Name = "toolStripDelayBorderless";
            this.toolStripDelayBorderless.Text = LanguageManager.Data("toolStripDelayBorderless");
            this.toolStripDelayBorderless.Click += new System.EventHandler(this.delayBorderlessToolStripMenuItem_Click);
            //
            // toolStripForceResize
            //
            resources.ApplyResources(this.toolStripForceResize, "toolStripForceResize");
            this.toolStripForceResize.Name = "toolStripForceResize";
            // this.toolStripForceResize.Text = LanguageManager.Data("toolStripForceResize");
            // TODO Language data
            this.toolStripForceResize.Text = "Force Resize";
            this.toolStripForceResize.Click += new System.EventHandler(this.toolStripForceResize_Click);
            // 
            // hideMouseCursorToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripHideMouseCursor, "toolStripHideMouseCursor");
            this.toolStripHideMouseCursor.CheckOnClick = true;
            this.toolStripHideMouseCursor.Name = "toolStripHideMouseCursor";
            this.toolStripHideMouseCursor.Text = LanguageManager.Data("toolStripHideMouseCursor");
            this.toolStripHideMouseCursor.Click += new System.EventHandler(this.hideMouseCursorToolStripMenuItem_Click);
            // 
            // hideWindowsTaskbarToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripHideWindowsTaskbar, "toolStripHideWindowsTaskbar");
            this.toolStripHideWindowsTaskbar.CheckOnClick = true;
            this.toolStripHideWindowsTaskbar.Name = "toolStripHideWindowsTaskbar";
            this.toolStripHideWindowsTaskbar.Text = LanguageManager.Data("toolStripHideWindowsTaskbar");
            this.toolStripHideWindowsTaskbar.Click += new System.EventHandler(this.hideWindowsTaskbarToolStripMenuItem_Click);
            // 
            // removeMenusToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripRemoveMenus, "toolStripRemoveMenus");
            this.toolStripRemoveMenus.CheckOnClick = true;
            this.toolStripRemoveMenus.Text = LanguageManager.Data("toolStripRemoveMenus");
            this.toolStripRemoveMenus.Name = "toolStripRemoveMenus";
            this.toolStripRemoveMenus.Click += new System.EventHandler(this.removeMenusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            // 
            // muteInBackgroundToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripMuteInBackground, "toolStripMuteInBackground");
            this.toolStripMuteInBackground.CheckOnClick = true;
            this.toolStripMuteInBackground.Name = "toolStripMuteInBackground";
            this.toolStripMuteInBackground.Text = LanguageManager.Data("toolStripMuteInBackground");
            this.toolStripMuteInBackground.Click += new System.EventHandler(this.muteInBackgroundToolStripMenuItem_Click);
            // 
            // contextRemoveFromFavsm
            // 
            resources.ApplyResources(this.contextRemoveFromFavs, "contextRemoveFromFavs");
            this.contextRemoveFromFavs.Name = "contextRemoveFromFavs";
            this.contextRemoveFromFavs.Text = LanguageManager.Data("contextRemoveFromFavs");
            this.contextRemoveFromFavs.Click += new System.EventHandler(this.btnRemoveFavorite_Click);
            // 
            // btnRemoveFavorite
            // 
            resources.ApplyResources(this.btnRemoveFavorite, "btnRemoveFavorite");
            this.btnRemoveFavorite.Image = global::BorderlessGaming.Properties.Resources.remove;
            this.btnRemoveFavorite.Name = "btnRemoveFavorite";
            this.btnRemoveFavorite.UseVisualStyleBackColor = true;
            this.btnRemoveFavorite.Click += new System.EventHandler(this.btnRemoveFavorite_Click);
            this.btnRemoveFavorite.MouseHover += new System.EventHandler(this.btnRemoveFavorite_MouseHover);
            // 
            // processLabel
            // 
            resources.ApplyResources(this.processLabel, "processLabel");
            this.processLabel.Name = "processLabel";
            this.processLabel.Text = LanguageManager.Data("processLabel");
            // 
            // favoritesLabel
            // 
            resources.ApplyResources(this.favoritesLabel, "favoritesLabel");
            this.favoritesLabel.Name = "favoritesLabel";
            this.favoritesLabel.Text = LanguageManager.Data("favoritesLabel");
            // 
            // trayIcon
            // 
            resources.ApplyResources(this.trayIcon, "trayIcon");
            this.trayIcon.ContextMenuStrip = this.trayIconContextMenu;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayIconContextMenu
            // 
            resources.ApplyResources(this.trayIconContextMenu, "trayIconContextMenu");
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem7,
            this.exitToolStripMenuItem});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOptions,
            this.toolsToolStripMenuItem,
            this.toolStripInfo,
             this.rainwayStrip
            });
            this.mnuMain.Name = "mnuMain";
            // 
            // toolStripOptions
            // 
            resources.ApplyResources(this.toolStripOptions, "toolStripOptions");
            this.toolStripOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRunOnStartup,
            this.toolStripLanguages,
            this.toolStripCheckForUpdates,
            this.toolStripMenuItem3,
            this.toolStripGlobalHotkey,
            this.toolStripMouseLock,
            this.toolStripMouseHide,
            this.toolStripMenuItem5,
            this.toolStripMinimizedToTray,
            this.toolStripCloseToTray,
            this.toolStripHideBalloonTips,
            this.toolStripSlowWindowDetection,
            this.toolStripViewFullProcessDetails,
            this.toolStripMenuItem10,
            this.toolStripRestoreProcesses});
            this.toolStripOptions.Name = "toolStripOptions";
            this.toolStripOptions.Text = LanguageManager.Data("toolStripOptions");
            // 

            // toolStripRunOnStartup
            // 
            resources.ApplyResources(this.toolStripRunOnStartup, "toolStripRunOnStartup");
            this.toolStripRunOnStartup.CheckOnClick = true;
            this.toolStripRunOnStartup.Name = "toolStripRunOnStartup";
            this.toolStripRunOnStartup.CheckedChanged += new System.EventHandler(this.toolStripRunOnStartup_CheckChanged);
            this.toolStripRunOnStartup.Text = LanguageManager.Data("toolStripRunOnStartup");
            // 
            // toolStripCheckForUpdates
            // 
            resources.ApplyResources(this.toolStripCheckForUpdates, "toolStripCheckForUpdates");
            this.toolStripCheckForUpdates.CheckOnClick = true;
            this.toolStripCheckForUpdates.Name = "toolStripCheckForUpdates";
            this.toolStripCheckForUpdates.Text = LanguageManager.Data("toolStripCheckForUpdates");
            this.toolStripCheckForUpdates.CheckedChanged += new System.EventHandler(this.toolStripCheckForUpdates_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // toolStripGlobalHotkey
            // 
            resources.ApplyResources(this.toolStripGlobalHotkey, "toolStripGlobalHotkey");
            this.toolStripGlobalHotkey.CheckOnClick = true;
            this.toolStripGlobalHotkey.Name = "toolStripGlobalHotkey";
            this.toolStripGlobalHotkey.CheckedChanged += new System.EventHandler(this.toolStripGlobalHotkey_CheckChanged);
            this.toolStripGlobalHotkey.Text = LanguageManager.Data("toolStripGlobalHotkey") + " (Win+F6)";
            // 
            // toolStripMouseLock
            // 
            resources.ApplyResources(this.toolStripMouseLock, "toolStripMouseLock");
            this.toolStripMouseLock.CheckOnClick = true;
            this.toolStripMouseLock.Name = "toolStripMouseLock";
            this.toolStripMouseLock.Text = LanguageManager.Data("toolStripMouseLock") + " (Scroll Lock)";
            this.toolStripMouseLock.CheckedChanged += new System.EventHandler(this.toolStripMouseLock_CheckChanged);
            // 
            // useMouseHideHotkeyWinScrollLockToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripMouseHide, "toolStripMouseHide");
            this.toolStripMouseHide.CheckOnClick = true;
            this.toolStripMouseHide.Text = LanguageManager.Data("toolStripMouseHide") + " (Win+Scroll Lock)";
            this.toolStripMouseHide.Name = "toolStripMouseHide";
            this.toolStripMouseHide.CheckedChanged += new System.EventHandler(this.useMouseHideHotkeyWinScrollLockToolStripMenuItem_CheckChanged);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // startMinimizedToTrayToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripMinimizedToTray, "toolStripMinimizedToTray");
            this.toolStripMinimizedToTray.CheckOnClick = true;
            this.toolStripMinimizedToTray.Text = LanguageManager.Data("toolStripMinimizedToTray");
            this.toolStripMinimizedToTray.Name = "toolStripMinimizedToTray";
            this.toolStripMinimizedToTray.CheckedChanged += new System.EventHandler(this.startMinimizedToTrayToolStripMenuItem_CheckedChanged);
            // 
            // closeToTrayToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripCloseToTray, "toolStripCloseToTray");
            this.toolStripCloseToTray.CheckOnClick = true;
            this.toolStripCloseToTray.Text = LanguageManager.Data("toolStripCloseToTray");
            this.toolStripCloseToTray.Name = "toolStripCloseToTray";
            this.toolStripCloseToTray.CheckedChanged += new System.EventHandler(this.closeToTrayToolStripMenuItem_CheckedChanged);
            // 
            // hideBalloonTipsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripHideBalloonTips, "toolStripHideBalloonTips");
            this.toolStripHideBalloonTips.CheckOnClick = true;
            this.toolStripHideBalloonTips.Text = LanguageManager.Data("toolStripHideBalloonTips");
            this.toolStripHideBalloonTips.Name = "toolStripHideBalloonTips";
            this.toolStripHideBalloonTips.CheckedChanged += new System.EventHandler(this.hideBalloonTipsToolStripMenuItem_CheckedChanged);
            // 
            // useSlowerWindowDetectionToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripSlowWindowDetection, "toolStripSlowWindowDetection");
            this.toolStripSlowWindowDetection.CheckOnClick = true;
            this.toolStripSlowWindowDetection.Text = LanguageManager.Data("toolStripSlowWindowDetection");
            this.toolStripSlowWindowDetection.Name = "toolStripSlowWindowDetection";
            this.toolStripSlowWindowDetection.Click += new System.EventHandler(this.useSlowerWindowDetectionToolStripMenuItem_Click);
            // 
            // viewFullProcessDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripViewFullProcessDetails, "toolStripViewFullProcessDetails");
            this.toolStripViewFullProcessDetails.CheckOnClick = true;
            this.toolStripViewFullProcessDetails.Text = LanguageManager.Data("toolStripViewFullProcessDetails");
            this.toolStripViewFullProcessDetails.Name = "toolStripViewFullProcessDetails";
            this.toolStripViewFullProcessDetails.CheckedChanged += new System.EventHandler(this.viewFullProcessDetailsToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem10
            // 
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            // 
            // resToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripRestoreProcesses, "toolStripRestoreProcesses");
            this.toolStripRestoreProcesses.Name = "toolStripRestoreProcesses";
            this.toolStripRestoreProcesses.Text = LanguageManager.Data("toolStripRestoreProcesses");
            this.toolStripRestoreProcesses.Click += new System.EventHandler(this.resetHiddenProcessesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPauseAutomaticProcessing,
            this.toolStripOpenDataFolder,
            this.toolStripMenuItem11,
            this.toolStripToggleMouseCursorVisibility,
            this.toolStripToggleWindowsTaskbar,
            this.toolStripMenuItem12,
            this.toolStripFullApplicationRefresh});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Text = LanguageManager.Data("toolsToolStripMenuItem");
            // 
            // pauseAutomaticProcessingToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripPauseAutomaticProcessing, "toolStripPauseAutomaticProcessing");
            this.toolStripPauseAutomaticProcessing.CheckOnClick = true;
            this.toolStripPauseAutomaticProcessing.Text = LanguageManager.Data("toolStripPauseAutomaticProcessing");
            this.toolStripPauseAutomaticProcessing.Name = "toolStripPauseAutomaticProcessing";
            this.toolStripPauseAutomaticProcessing.Click += new System.EventHandler(this.pauseAutomaticProcessingToolStripMenuItem_Click);
            // 
            // openDataFolderToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripOpenDataFolder, "toolStripOpenDataFolder");
            this.toolStripOpenDataFolder.Name = "toolStripOpenDataFolder";
            this.toolStripOpenDataFolder.Text = LanguageManager.Data("toolStripOpenDataFolder");
            this.toolStripOpenDataFolder.Click += new System.EventHandler(this.openDataFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            // 
            // toggleMouseCursorVisibilityToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripToggleMouseCursorVisibility, "toolStripToggleMouseCursorVisibility");
            this.toolStripToggleMouseCursorVisibility.Name = "toolStripToggleMouseCursorVisibility";
            this.toolStripToggleMouseCursorVisibility.Text =
                LanguageManager.Data("toolStripToggleMouseCursorVisibility");
            this.toolStripToggleMouseCursorVisibility.Click += new System.EventHandler(this.toggleMouseCursorVisibilityToolStripMenuItem_Click);
            // 
            // toggleWindowsTaskbarVisibilityToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripToggleWindowsTaskbar, "toolStripToggleWindowsTaskbar");
            this.toolStripToggleWindowsTaskbar.Name = "toolStripToggleWindowsTaskbar";
            this.toolStripToggleWindowsTaskbar.Text =  LanguageManager.Data("toolStripToggleWindowsTaskbar");
            this.toolStripToggleWindowsTaskbar.Click += new System.EventHandler(this.toggleWindowsTaskbarVisibilityToolStripMenuItem_Click);
            //
            // rainwayStrip
            //
            resources.ApplyResources(this.rainwayStrip, "rainwayStrip");
            this.rainwayStrip.Text = "Check Out Rainway";
            this.rainwayStrip.Image = Resources.master_glyph;
            this.rainwayStrip.Click += new System.EventHandler(this.checkOutRainwayToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            // 
            // fullApplicationRefreshToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripFullApplicationRefresh, "toolStripFullApplicationRefresh");
            this.toolStripFullApplicationRefresh.Name = "toolStripFullApplicationRefresh";
            this.toolStripFullApplicationRefresh.Text = LanguageManager.Data("toolStripFullApplicationRefresh");
            this.toolStripFullApplicationRefresh.Click += new System.EventHandler(this.fullApplicationRefreshToolStripMenuItem_Click);
            // 
            // toolStripInfo
            // 
            resources.ApplyResources(this.toolStripInfo, "toolStripInfo");
            this.toolStripInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsageGuide,
            this.toolStripRegexReference,
            this.toolStripMenuItem13,
            this.toolStripReportBug,
            this.toolStripSupportUs,
            this.toolStripMenuItem2,
            this.toolStripAbout});
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Text =
                LanguageManager.Data("toolStripInfo");
            // 
            // usageGuideToolStripMenuItem
            // 
            resources.ApplyResources(this.toolStripUsageGuide, "toolStripUsageGuide");
            this.toolStripUsageGuide.Name = "toolStripUsageGuide";
            this.toolStripUsageGuide.Text = LanguageManager.Data("toolStripUsageGuide");
            this.toolStripUsageGuide.Click += new System.EventHandler(this.usageGuideToolStripMenuItem_Click);
            // 
            // toolStripRegexReference
            // 
            resources.ApplyResources(this.toolStripRegexReference, "toolStripRegexReference");
            this.toolStripRegexReference.Name = "toolStripRegexReference";
            this.toolStripRegexReference.Text = LanguageManager.Data("toolStripRegexReference");
            this.toolStripRegexReference.Click += new System.EventHandler(this.toolStripRegexReference_Click);
            // 
            // toolStripMenuItem13
            // 
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            // 
            // toolStripReportBug
            // 
            resources.ApplyResources(this.toolStripReportBug, "toolStripReportBug");
            this.toolStripReportBug.Name = "toolStripReportBug";
            this.toolStripReportBug.Text = LanguageManager.Data("toolStripReportBug");
            this.toolStripReportBug.Click += new System.EventHandler(this.toolStripReportBug_Click);
            // 
            // toolStripSupportUs
            // 
            resources.ApplyResources(this.toolStripSupportUs, "toolStripSupportUs");
            this.toolStripSupportUs.Name = "toolStripSupportUs";
            this.toolStripSupportUs.Text = LanguageManager.Data("toolStripSupportUs");
            this.toolStripSupportUs.Click += new System.EventHandler(this.toolStripSupportUs_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // toolStripAbout
            // 
            resources.ApplyResources(this.toolStripAbout, "toolStripAbout");
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Text = LanguageManager.Data("toolStripAbout");
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.processLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.favoritesLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstProcesses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstFavorites, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.addSelectedItem);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveFavorite);
            this.flowLayoutPanel1.Controls.Add(this.btnMakeBorderless);
            this.flowLayoutPanel1.Controls.Add(this.btnRestoreWindow);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnRestoreWindow
            // 
            resources.ApplyResources(this.btnRestoreWindow, "btnRestoreWindow");
            this.btnRestoreWindow.Image = global::BorderlessGaming.Properties.Resources.bordered;
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.UseVisualStyleBackColor = true;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            this.btnRestoreWindow.MouseHover += new System.EventHandler(this.btnRestoreWindow_MouseHover);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblUpdateStatus
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = LanguageManager.Data("statusLabel");
            // 
            // toolStripLanguages
            // 
            resources.ApplyResources(this.toolStripLanguages, "toolStripLanguages");
            this.toolStripLanguages.Name = "toolStripLanguages";
            this.toolStripLanguages.Text = LanguageManager.Data("toolStripLanguages");
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.processContext.ResumeLayout(false);
            this.mnuFavoritesContext.ResumeLayout(false);
            this.trayIconContextMenu.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeBorderless;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button addSelectedItem;
        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Button btnRemoveFavorite;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label favoritesLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripRunOnStartup;
        private System.Windows.Forms.ToolStripMenuItem toolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem rainwayStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripReportBug;
        private System.Windows.Forms.ToolStripMenuItem toolStripSupportUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegexReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip processContext;
        private System.Windows.Forms.ToolStripMenuItem contextAddToFavs;
        private System.Windows.Forms.ToolStripMenuItem contextBorderless;
        private System.Windows.Forms.ToolStripMenuItem contextBorderlessOn;
        private System.Windows.Forms.ToolStripMenuItem contextFavScreen;
        private System.Windows.Forms.ContextMenuStrip mnuFavoritesContext;
        private System.Windows.Forms.ToolStripMenuItem contextRemoveFromFavs;
        private System.Windows.Forms.ToolStripMenuItem toolStripGlobalHotkey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseLock;
        private System.Windows.Forms.ToolStripMenuItem toolStripByTheWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripByProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripByRegex;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdjustWindowBounds;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripAutomaximize;
        private System.Windows.Forms.Button btnRestoreWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMinimizedToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripCloseToTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideBalloonTips;
        private System.Windows.Forms.ToolStripMenuItem toolStripCheckForUpdates;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;//this might get replaced if you redo anything in the form designer
        private System.Windows.Forms.ToolStripMenuItem toolStripViewFullProcessDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetSetWindowSize;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideProcess;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveMenus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelayBorderless;
        private System.Windows.Forms.ToolStripMenuItem toolStripForceResize;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripSetWindowTitle;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideWindowsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripHideMouseCursor;
        private System.Windows.Forms.ToolStripMenuItem toolStripToggleMouseCursorVisibility;
        private System.Windows.Forms.ToolStripMenuItem toolStripMouseHide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripRestoreProcesses;
        private System.Windows.Forms.ToolStripMenuItem toolStripPauseAutomaticProcessing;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripNoSizeChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenDataFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripFullApplicationRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripSlowWindowDetection;
        private System.Windows.Forms.ToolStripMenuItem toolStripUsageGuide;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMuteInBackground;
        private System.Windows.Forms.ToolStripMenuItem toolStripLanguages;
    }
}