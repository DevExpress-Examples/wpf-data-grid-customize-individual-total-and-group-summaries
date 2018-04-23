using System;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Grid;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Markup;

namespace DXSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            
           
        }
    }


    public class CustConverter : IMultiValueConverter {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            GridColumn column = values[0] as GridColumn;
            IEnumerable<GridGroupSummaryData> data = values[1] as IEnumerable<GridGroupSummaryData>;
            IEnumerable<GridGroupSummaryData> items = new List<GridGroupSummaryData>();
            if (column != null && data != null) {
                items = from GridGroupSummaryData in data where GridGroupSummaryData.Column == column select GridGroupSummaryData;
            }
            return items;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            return null;
        }
    }
}