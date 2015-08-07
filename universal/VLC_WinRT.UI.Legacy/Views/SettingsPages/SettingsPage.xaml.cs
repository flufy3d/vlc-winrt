﻿using System;
using Windows.ApplicationModel;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using VLC_WinRT.Helpers;
using VLC_WinRT.ViewModels;
using Windows.UI.Xaml.Media;
using Windows.UI;
using VLC_WinRT.SharedBackground.Helpers.MusicPlayer;

namespace VLC_WinRT.Views.VariousPages
{
    public sealed partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            this.InitializeComponent();
            Package thisPackage = Package.Current;
            PackageVersion version = thisPackage.Id.Version;
            string appVersion = string.Format("{0}.{1}.{2}.{3}",
                version.Major, version.Minor, version.Build, version.Revision);
            AppVersion.Text = "v" + appVersion;
            foreach(var element in RootPanel.Children)
            {
#if WINDOWS_PHONE_APP
                if((string)((FrameworkElement)element).Tag == "WindowsOnly")
                {
                    element.Visibility = Visibility.Collapsed;
                }
#endif
            }
        }
    }
}