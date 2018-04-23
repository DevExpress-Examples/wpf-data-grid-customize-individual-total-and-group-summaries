Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace DXSample
	Public Class SimpleData
		Implements INotifyPropertyChanged

		Private _Count As Integer
		Private _Price As Double
		Private _Description As String
		Private _Name As String
		Private _ID As Integer


		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				If _ID = value Then
					Return
				End If
				_ID = value
				OnPropertyChanged("ID")
			End Set
		End Property

		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				If _Name = value Then
					Return
				End If
				_Name = value
				OnPropertyChanged("Name")
			End Set
		End Property

		Public Property Description() As String
			Get
				Return _Description
			End Get
			Set(ByVal value As String)
				If _Description = value Then
					Return
				End If
				_Description = value
				OnPropertyChanged("Description")
			End Set
		End Property

		Public Property Price() As Double
			Get
				Return _Price
			End Get
			Set(ByVal value As Double)
				If _Price = value Then
					Return
				End If
				_Price = value
				OnPropertyChanged("Price")
			End Set
		End Property


		Public Property Count() As Integer
			Get
				Return _Count
			End Get
			Set(ByVal value As Integer)
				If _Count = value Then
					Return
				End If
				_Count = value
				OnPropertyChanged("Count")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Sub OnPropertyChanged(ByVal [property] As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs([property]))
		End Sub
	End Class
End Namespace
