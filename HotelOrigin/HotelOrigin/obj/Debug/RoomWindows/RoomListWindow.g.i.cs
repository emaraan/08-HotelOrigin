﻿#pragma checksum "..\..\..\RoomWindows\RoomListWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "77DF1D52109AB4B7131A4CB46ED46EDA"
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
    /// RoomListWindow
    /// </summary>
    public partial class RoomListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RoomWindows\RoomListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridRooms;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RoomWindows\RoomListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddRoom;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\RoomWindows\RoomListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDeleteRoom;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelOrigin;component/roomwindows/roomlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RoomWindows\RoomListWindow.xaml"
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
            this.dataGridRooms = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\RoomWindows\RoomListWindow.xaml"
            this.dataGridRooms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridRooms_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonAddRoom = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\RoomWindows\RoomListWindow.xaml"
            this.buttonAddRoom.Click += new System.Windows.RoutedEventHandler(this.buttonAddRoom_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonDeleteRoom = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\RoomWindows\RoomListWindow.xaml"
            this.buttonDeleteRoom.Click += new System.Windows.RoutedEventHandler(this.buttonDeleteRoom_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

