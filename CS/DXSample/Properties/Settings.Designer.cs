﻿// Developer Express Code Central Example:
// How to style GridControl's group summary items via the GroupColumnSummaryItemTemplate property
// 
// When group summary items are aligned by columns, it is necessary to use the
// TableView's GroupColumnSummaryItemTemplate property to style GridControl group
// summary items. The main idea of this approach is to define a custom ItemsControl
// inside the GroupColumnSummaryItemTemplate, bind its ItemsSource property to the
// collection of group summaries and show summary items as child ItemsControl
// elements. To customize summaries you can use ItemsControl properties, for
// instance, ItemTemplateSelector.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4998

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXSample.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }
    }
}
