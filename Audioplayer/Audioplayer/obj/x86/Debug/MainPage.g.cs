﻿#pragma checksum "C:\Users\Lone_Traveler\source\repos\Audioplayer\Audioplayer\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D7A8CCE31415F649182B04B3882513B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Audioplayer
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 49
                {
                    this.list = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.list).SelectionChanged += this.list_SelectionChanged;
                }
                break;
            case 3: // MainPage.xaml line 42
                {
                    this.open = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.open).Click += this.open_Click;
                }
                break;
            case 4: // MainPage.xaml line 43
                {
                    this.CreatePlayList = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CreatePlayList).Click += this.CreatePlayList_Click;
                }
                break;
            case 5: // MainPage.xaml line 44
                {
                    this.namePlaylist = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 45
                {
                    this.AddPlayList = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddPlayList).Click += this.AddPlayList_Click;
                }
                break;
            case 7: // MainPage.xaml line 46
                {
                    this.viewfile = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.viewfile).Click += this.viewfile_Click;
                }
                break;
            case 8: // MainPage.xaml line 29
                {
                    this.stop = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.stop).Click += this.stop_Click;
                }
                break;
            case 9: // MainPage.xaml line 30
                {
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 10: // MainPage.xaml line 31
                {
                    this.pouse = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.pouse).Click += this.pouse_Click;
                }
                break;
            case 11: // MainPage.xaml line 32
                {
                    this.volue = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volue).ValueChanged += this.volue_ValueChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

