﻿#pragma checksum "D:\Sample Project\git\CustomBackgroudPlayer\CustomBackgroudPlayer\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "89AFDCB156707A70E59C7509127158BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace CustomBackgroudPlayer {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button prevButton;
        
        internal System.Windows.Controls.Button playButton;
        
        internal System.Windows.Controls.Button nextButton;
        
        internal System.Windows.Controls.TextBlock txtCurrentTrack;
        
        internal System.Windows.Controls.TextBox fileUrl;
        
        internal System.Windows.Controls.Button play;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/CustomBackgroudPlayer;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.prevButton = ((System.Windows.Controls.Button)(this.FindName("prevButton")));
            this.playButton = ((System.Windows.Controls.Button)(this.FindName("playButton")));
            this.nextButton = ((System.Windows.Controls.Button)(this.FindName("nextButton")));
            this.txtCurrentTrack = ((System.Windows.Controls.TextBlock)(this.FindName("txtCurrentTrack")));
            this.fileUrl = ((System.Windows.Controls.TextBox)(this.FindName("fileUrl")));
            this.play = ((System.Windows.Controls.Button)(this.FindName("play")));
        }
    }
}
