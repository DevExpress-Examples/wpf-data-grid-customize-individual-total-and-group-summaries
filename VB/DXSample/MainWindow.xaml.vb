Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Controls
Imports System.Collections.Generic
Imports System.Windows.Data
Imports System.Globalization

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New ViewModel()
        End Sub
    End Class

    Public Class CustConverter
        Implements IMultiValueConverter

        Public Function Convert(ByVal values As Object(), ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim column As GridColumn = TryCast(values(0), GridColumn)
            Dim data As IEnumerable(Of GridGroupSummaryData) = TryCast(values(1), IEnumerable(Of GridGroupSummaryData))
            Dim items As IEnumerable(Of GridGroupSummaryData) = New List(Of GridGroupSummaryData)()
            If column IsNot Nothing AndAlso data IsNot Nothing Then
                items = From GridGroupSummaryData In data Where GridGroupSummaryData.Column Is column Select GridGroupSummaryData
            End If

            Return items
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes As Type(), ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class
End Namespace
