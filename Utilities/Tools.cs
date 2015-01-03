﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using BorderlessGaming.Properties;

namespace BorderlessGaming.Utilities
{
    public static class Tools
    {
        public static void GotoSite(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch { }
        }

        private static bool HasInternetConnection
        {
            //There is absolutely no way you can reliably check if there is an internet connection
            get
            {
                bool result = false;

                try
                {
                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        using (Ping p = new Ping())
                        {
                            result = (p.Send("8.8.8.8", 15000).Status == IPStatus.Success) || (p.Send("8.8.4.4", 15000).Status == IPStatus.Success) || (p.Send("4.2.2.1", 15000).Status == IPStatus.Success);
                        }
                    }
                }
                catch { }

                return result;
            }
        }

        public static void CheckForUpdates()
        {
            if (Tools.HasInternetConnection)
            {
                string _releasePageURL = "";
                Version _newVersion = null;
                const string _versionConfig = "https://raw.github.com/Codeusa/Borderless-Gaming/master/version.xml";
                XmlTextReader _reader = new XmlTextReader(_versionConfig);
                _reader.MoveToContent();
                string _elementName = "";
                try
                {
                    if ((_reader.NodeType == XmlNodeType.Element) && (_reader.Name == "borderlessgaming"))
                    {
                        while (_reader.Read())
                        {
                            switch (_reader.NodeType)
                            {
                                case XmlNodeType.Element:
                                    _elementName = _reader.Name;
                                    break;
                                default:
                                    if ((_reader.NodeType == XmlNodeType.Text) && (_reader.HasValue))
                                    {
                                        switch (_elementName)
                                        {
                                            case "version":
                                                _newVersion = new Version(_reader.Value);
                                                break;
                                            case "url":
                                                _releasePageURL = _reader.Value;
                                                break;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.ErrorUpdates, Resources.ErrorHeader, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    _reader.Close();
                }

                Version applicationVersion = Assembly.GetExecutingAssembly().GetName().Version;
                if (applicationVersion.CompareTo(_newVersion) < 0)
                {
                    if (MessageBox.Show(Resources.InfoUpdateAvailable, Resources.InfoUpdatesHeader,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Tools.GotoSite(_releasePageURL);
                    }
                }
            }
        }

        /// <summary>
        ///     Gets the smallest Rectangle containing two input Rectangles
        /// </summary>
        public static Rectangle GetContainingRectangle(Rectangle a, Rectangle b)
        {
            Point amin = new Point(a.X, a.Y);
            Point amax = new Point(a.X + a.Width, a.Y + a.Height);
            Point bmin = new Point(b.X, b.Y);
            Point bmax = new Point(b.X + b.Width, b.Y + b.Height);
            Point nmin = new Point(0, 0);
            Point nmax = new Point(0, 0);

            nmin.X = (amin.X < bmin.X) ? amin.X : bmin.X;
            nmin.Y = (amin.Y < bmin.Y) ? amin.Y : bmin.Y;
            nmax.X = (amax.X > bmax.X) ? amax.X : bmax.X;
            nmax.Y = (amax.Y > bmax.Y) ? amax.Y : bmax.Y;

            return new Rectangle(nmin, new Size(nmax.X - nmin.X, nmax.Y - nmin.Y));
        }

        public static string Input_Text(string sTitle, string sInstructions, string sDefaultValue = "")
        {
            try
            {
                using (Forms.InputText inputForm = new Forms.InputText())
                {
                    inputForm.Title = sTitle;
                    inputForm.Instructions = sInstructions;
                    inputForm.Input = sDefaultValue;
                    
                    if (inputForm.ShowDialog() == DialogResult.OK)
                        return inputForm.Input;

                    return sDefaultValue;
                }
            }
            catch { }

            return string.Empty;
        }

        public static List<string> StartupParameters
        {
            get
            {
                try
                {
                    List<string> startup_parameters_mixed = new List<string>();
                    startup_parameters_mixed.AddRange(Environment.GetCommandLineArgs());

                    List<string> startup_parameters_lower = new List<string>();
                    foreach (string s in startup_parameters_mixed)
                        startup_parameters_lower.Add(s.Trim().ToLower());

                    startup_parameters_mixed.Clear();

                    return startup_parameters_lower;
                }
                catch
                {
                    try { return new List<string>(Environment.GetCommandLineArgs()); } catch { }
                }

                return new List<string>();
            }
        }
    }
}