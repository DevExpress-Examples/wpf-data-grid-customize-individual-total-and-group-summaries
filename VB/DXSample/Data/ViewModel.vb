Imports System.Collections.ObjectModel

Namespace DXSample
	Public Class ViewModel

		Public Property Collection() As ObservableCollection(Of SimpleData)

		Public Sub New()
			Collection = New ObservableCollection(Of SimpleData)()
			Collection.Add(New SimpleData() With {
				.City = "Aachen",
				.UnitPrice = 10,
				.Quantity = 20,
				.Discount = 0,
				.Freight = 30.54
			})
			Collection.Add(New SimpleData() With {
				.City = "Aachen",
				.UnitPrice = 6.20,
				.Quantity = 12,
				.Discount = 0,
				.Freight = 30.54
			})
			Collection.Add(New SimpleData() With {
				.City = "Aachen",
				.UnitPrice = 14.40,
				.Quantity = 12,
				.Discount = 0,
				.Freight = 30.54
			})
			Collection.Add(New SimpleData() With {
				.City = "Aachen",
				.UnitPrice = 4.80,
				.Quantity = 18,
				.Discount = 0,
				.Freight = 4.45
			})
			Collection.Add(New SimpleData() With {
				.City = "Aachen",
				.UnitPrice = 21,
				.Quantity = 20,
				.Discount = 0.03,
				.Freight = 33.35
			})
			Collection.Add(New SimpleData() With {
				.City = "Aachen",
				.UnitPrice = 6,
				.Quantity = 7,
				.Discount = 0,
				.Freight = 149.74
			})

			Collection.Add(New SimpleData() With {
				.City = "Barcelona",
				.UnitPrice = 16.80,
				.Quantity = 5,
				.Discount = 0,
				.Freight = 10.14
			})
			Collection.Add(New SimpleData() With {
				.City = "Barcelona",
				.UnitPrice = 6.20,
				.Quantity = 5,
				.Discount = 0,
				.Freight = 10.14
			})
			Collection.Add(New SimpleData() With {
				.City = "Barcelona",
				.UnitPrice = 14.40,
				.Quantity = 5,
				.Discount = 0.06,
				.Freight = 18.69
			})
			Collection.Add(New SimpleData() With {
				.City = "Barcelona",
				.UnitPrice = 4.80,
				.Quantity = 7,
				.Discount = 0,
				.Freight = 18.69
			})
			Collection.Add(New SimpleData() With {
				.City = "Barcelona",
				.UnitPrice = 21,
				.Quantity = 5,
				.Discount = 0,
				.Freight = 6.54
			})
			Collection.Add(New SimpleData() With {
				.City = "Barcelona",
				.UnitPrice = 6,
				.Quantity = 5,
				.Discount = 0,
				.Freight = 1.36
			})

			Collection.Add(New SimpleData() With {
				.City = "London",
				.UnitPrice = 8,
				.Quantity = 30,
				.Discount = 0,
				.Freight = 22.77
			})
			Collection.Add(New SimpleData() With {
				.City = "London",
				.UnitPrice = 26.60,
				.Quantity = 9,
				.Discount = 0,
				.Freight = 22.77
			})
			Collection.Add(New SimpleData() With {
				.City = "London",
				.UnitPrice = 3.60,
				.Quantity = 25,
				.Discount = 0.05,
				.Freight = 18.69
			})
			Collection.Add(New SimpleData() With {
				.City = "London",
				.UnitPrice = 15.60,
				.Quantity = 27,
				.Discount = 0,
				.Freight = 34.34
			})
			Collection.Add(New SimpleData() With {
				.City = "London",
				.UnitPrice = 27.20,
				.Quantity = 56,
				.Discount = 0,
				.Freight = 6.54
			})
			Collection.Add(New SimpleData() With {
				.City = "London",
				.UnitPrice = 28.80,
				.Quantity = 70,
				.Discount = 0.15,
				.Freight = 1.36
			})
		End Sub
	End Class
End Namespace