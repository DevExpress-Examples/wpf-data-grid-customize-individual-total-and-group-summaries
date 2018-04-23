using System;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Grid;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DXSample
{
    public class ItemsControlEx : ItemsControl
    {
        public static readonly DependencyProperty AllItemsProperty =
            DependencyProperty.Register("AllItems", typeof(ObservableCollection<GridGroupSummaryData>), typeof(ItemsControlEx), new PropertyMetadata(null, OnAllItemsPropertyChanged));
        public static readonly DependencyProperty ColumnProperty =
            DependencyProperty.Register("Column", typeof(ColumnBase), typeof(ItemsControlEx), new PropertyMetadata(null, OnColumnPropertyChanged));
        public ObservableCollection<GridGroupSummaryData> AllItems
        {
            get { return (ObservableCollection<GridGroupSummaryData>)GetValue(AllItemsProperty); }
            set { SetValue(AllItemsProperty, value); }
        }
        public ColumnBase Column
        {
            get { return (ColumnBase)GetValue(ColumnProperty); }
            set { SetValue(ColumnProperty, value); }
        }

        static void OnAllItemsPropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ((ItemsControlEx)o).OnAllItemsChanged(e);
        }
        static void OnColumnPropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ((ItemsControlEx)o).OnColumnChanged(e);
        }
        void OnAllItemsChanged(DependencyPropertyChangedEventArgs e)
        {
            UnSubscribe(e.OldValue as ObservableCollection<GridGroupSummaryColumnData>);
            Subscribe(e.NewValue as ObservableCollection<GridGroupSummaryColumnData>);
            UpdateItemsSource();
        }
        void OnColumnChanged(DependencyPropertyChangedEventArgs e)
        {
            UpdateItemsSource();
        }
        void Subscribe(ObservableCollection<GridGroupSummaryColumnData> collection)
        {
            if (collection != null)
                collection.CollectionChanged += OnCollectionChanged;
        }
        void UnSubscribe(ObservableCollection<GridGroupSummaryColumnData> collection)
        {
            if (collection != null)
                collection.CollectionChanged -= OnCollectionChanged;
        }
        void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateItemsSource();
        }
        void UpdateItemsSource()
        {
            List<GridGroupSummaryData> data = new List<GridGroupSummaryData>();
            if (Column != null && AllItems != null)
            {
                foreach (var item in AllItems)
                    if (item.Column == Column)
                        data.Add(item);
            }
            ItemsSource = data;
        }
    }
}
