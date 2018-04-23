using System;
using System.Linq;
using System.Windows;
using DevExpress.Data;
using DevExpress.Xpf.Grid;
using System.Windows.Controls;
using System.Collections.Generic;

namespace DXSample
{
    public class GroupSummaryDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }
        public DataTemplate Template3 { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            GridGroupSummaryData data = item as GridGroupSummaryData;

            if (data == null)
                return Template1;

            if (data.Column.FieldName == "Count")
                return Template2;
            if (data.Column.FieldName == "Price" && data.SummaryItem.SummaryType == SummaryItemType.Sum)
                return Template3;
            else
                return Template1;
        }
    }
}
