Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Controls
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace DXSample
	Public Class ItemsControlEx
		Inherits ItemsControl

		Public Shared ReadOnly AllItemsProperty As DependencyProperty = DependencyProperty.Register("AllItems", GetType(ObservableCollection(Of GridGroupSummaryData)), GetType(ItemsControlEx), New PropertyMetadata(Nothing, AddressOf OnAllItemsPropertyChanged))
		Public Shared ReadOnly ColumnProperty As DependencyProperty = DependencyProperty.Register("Column", GetType(ColumnBase), GetType(ItemsControlEx), New PropertyMetadata(Nothing, AddressOf OnColumnPropertyChanged))
		Public Property AllItems() As ObservableCollection(Of GridGroupSummaryData)
			Get
				Return CType(GetValue(AllItemsProperty), ObservableCollection(Of GridGroupSummaryData))
			End Get
			Set(ByVal value As ObservableCollection(Of GridGroupSummaryData))
				SetValue(AllItemsProperty, value)
			End Set
		End Property
		Public Property Column() As ColumnBase
			Get
				Return CType(GetValue(ColumnProperty), ColumnBase)
			End Get
			Set(ByVal value As ColumnBase)
				SetValue(ColumnProperty, value)
			End Set
		End Property

		Private Shared Sub OnAllItemsPropertyChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			CType(o, ItemsControlEx).OnAllItemsChanged(e)
		End Sub
		Private Shared Sub OnColumnPropertyChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			CType(o, ItemsControlEx).OnColumnChanged(e)
		End Sub
		Private Sub OnAllItemsChanged(ByVal e As DependencyPropertyChangedEventArgs)
			UnSubscribe(TryCast(e.OldValue, ObservableCollection(Of GridGroupSummaryColumnData)))
			Subscribe(TryCast(e.NewValue, ObservableCollection(Of GridGroupSummaryColumnData)))
			UpdateItemsSource()
		End Sub
		Private Sub OnColumnChanged(ByVal e As DependencyPropertyChangedEventArgs)
			UpdateItemsSource()
		End Sub
		Private Sub Subscribe(ByVal collection As ObservableCollection(Of GridGroupSummaryColumnData))
			If collection IsNot Nothing Then
				AddHandler collection.CollectionChanged, AddressOf OnCollectionChanged
			End If
		End Sub
		Private Sub UnSubscribe(ByVal collection As ObservableCollection(Of GridGroupSummaryColumnData))
			If collection IsNot Nothing Then
				RemoveHandler collection.CollectionChanged, AddressOf OnCollectionChanged
			End If
		End Sub
		Private Sub OnCollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
			UpdateItemsSource()
		End Sub
		Private Sub UpdateItemsSource()
			Dim data As New List(Of GridGroupSummaryData)()
			If Column IsNot Nothing AndAlso AllItems IsNot Nothing Then
				For Each item In AllItems
					If item.Column Is Column Then
						data.Add(item)
					End If
				Next item
			End If
			ItemsSource = data
		End Sub
	End Class
End Namespace
