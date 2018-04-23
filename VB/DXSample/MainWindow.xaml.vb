Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Controls
Imports System.Collections.Generic
Imports System.Windows.Data
Imports System.Globalization
Imports System.Windows.Markup

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			DataContext = New ViewModel()
			Dim n As New ItemsControlEx()

		End Sub
	End Class

	Public Class ColumnBaseToGridColumnConverter
		Inherits MarkupExtension
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Return TryCast(value, GridColumn)
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New InvalidOperationException("The method or operation is not implemented.")
		End Function

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace