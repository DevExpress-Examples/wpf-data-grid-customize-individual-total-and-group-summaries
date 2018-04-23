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
            ItemsControlEx n = new ItemsControlEx();
           
        }
    }

    public class ColumnBaseToGridColumnConverter : MarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return value as GridColumn;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new InvalidOperationException("The method or operation is not implemented.");
        }

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}