Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace DXSample
	Public Class ViewModel

		Public Property Collection() As ObservableCollection(Of SimpleData)

		Public Sub New()
			Dim rand As New Random()
			Collection = New ObservableCollection(Of SimpleData)()
			For i As Integer = 0 To 99
				Collection.Add(New SimpleData() With {.ID = i, .Name = "Name" & i, .Description = "Description" & i, .Price = rand.Next(0, 10000) \ rand.Next(1, 10), .Count = rand.Next(0, 1000)})
			Next i
		End Sub
	End Class
End Namespace