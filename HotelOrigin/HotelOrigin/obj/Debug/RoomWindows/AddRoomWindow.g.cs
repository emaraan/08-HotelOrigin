﻿#pragma checksum "..\..\..\RoomWindows\AddRoomWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81BE5B3CEFC291D57EE72D7631B899ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelOrigin;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace HotelOrigin {
    
    
    /// <summary>
    /// AddRoomWindow
    /// </summary>
    public partial class AddRoomWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSaveRoom;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockAddRoomHeading;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockNumberOfBeds;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNumberOfBeds;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockHasTV;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\RoomWindows\AddRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HotelOrigin;component/roomwindows/addroomwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RoomWindows\AddRoomWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonSaveRoom = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\RoomWindows\AddRoomWindow.xaml"
            this.buttonSaveRoom.Click += new System.Windows.RoutedEventHandler(this.buttonSaveRoom_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBlockAddRoomHeading = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.textBlockRoomNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.textBoxRoomNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBlockNumberOfBeds = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.textBoxNumberOfBeds = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textBlockHasTV = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.checkBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\..\RoomWindows\AddRoomWindow.xaml"
            this.checkBox.Checked += new System.Windows.RoutedEventHandler(this.checkBox_Checked);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\RoomWindows\AddRoomWindow.xaml"
            this.checkBox.Unchecked += new System.Windows.RoutedEventHandler(this.checkBox_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

