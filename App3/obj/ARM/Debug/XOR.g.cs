﻿#pragma checksum "C:\Users\gurbi\Desktop\App3\App3\XOR.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98468FA7D8EA99B156570AF0FEE3F53B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App3
{
    partial class XOR : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\XOR.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.backButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.schemat = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.siatka = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.nameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 20 "..\..\..\XOR.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.nameTextBlock).SizeChanged += this.nameTextBlock_SizeChanged;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

