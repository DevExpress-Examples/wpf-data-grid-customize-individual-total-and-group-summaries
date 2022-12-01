Imports System.ComponentModel

Namespace DXSample

    Public Class SimpleData
        Implements INotifyPropertyChanged

        Private _Count As Integer

        Private _Price As Double

        Private _Description As String

        Private _Name As String

        Private _ID As Integer

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Set(ByVal value As Integer)
                If _ID = value Then Return
                _ID = value
                OnPropertyChanged("ID")
            End Set
        End Property

        Public Property Name As String
            Get
                Return _Name
            End Get

            Set(ByVal value As String)
                If Equals(_Name, value) Then Return
                _Name = value
                OnPropertyChanged("Name")
            End Set
        End Property

        Public Property Description As String
            Get
                Return _Description
            End Get

            Set(ByVal value As String)
                If Equals(_Description, value) Then Return
                _Description = value
                OnPropertyChanged("Description")
            End Set
        End Property

        Public Property Price As Double
            Get
                Return _Price
            End Get

            Set(ByVal value As Double)
                If _Price = value Then Return
                _Price = value
                OnPropertyChanged("Price")
            End Set
        End Property

        Public Property Count As Integer
            Get
                Return _Count
            End Get

            Set(ByVal value As Integer)
                If _Count = value Then Return
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
