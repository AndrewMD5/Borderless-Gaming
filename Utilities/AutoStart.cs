﻿using System;
using System.IO;
using System.Windows.Forms;
using File = System.IO.File;
#if !__MonoCS__
using IWshRuntimeLibrary;

#endif

namespace BorderlessGaming.Utilities
{
    public static class AutoStart
    {
        private static bool Create(string shortcutPath, string targetPath, string arguments = "")
        {
#if !__MonoCS__
            if (!string.IsNullOrEmpty(shortcutPath) && !string.IsNullOrEmpty(targetPath) && File.Exists(targetPath))
            {
                try
                {
                    IWshShell wsh = new WshShellClass();
                    var shortcut = (IWshShortcut) wsh.CreateShortcut(shortcutPath);
                    shortcut.TargetPath = targetPath;
                    shortcut.Arguments = arguments;
                    shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);
                    shortcut.Save();

                    return true;
                }
                catch
                {
                }
            }
#endif
            return false;
        }

        private static bool Delete(string shortcutPath)
        {
            if (!string.IsNullOrEmpty(shortcutPath) && File.Exists(shortcutPath))
            {
                File.Delete(shortcutPath);
                return true;
            }

            return false;
        }

        public static bool SetShortcut(bool create, Environment.SpecialFolder specialFolder, string arguments = "")
        {
            var shortcutPath = GetShortcutPath(specialFolder);

            if (create)
            {
                return Create(shortcutPath, Application.ExecutablePath, arguments);
            }

            return Delete(shortcutPath);
        }

        public static bool CheckShortcut(Environment.SpecialFolder specialFolder)
        {
            var shortcutPath = GetShortcutPath(specialFolder);
            return File.Exists(shortcutPath);
        }

        private static string GetShortcutPath(Environment.SpecialFolder specialFolder)
        {
            var folderPath = Environment.GetFolderPath(specialFolder);
            var shortcutPath = Path.Combine(folderPath, Application.ProductName);

            if (!Path.GetExtension(shortcutPath).Equals(".lnk", StringComparison.InvariantCultureIgnoreCase))
            {
                shortcutPath = Path.ChangeExtension(shortcutPath, "lnk");
            }

            return shortcutPath;
        }
    }
}