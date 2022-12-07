Imports Microsoft.VisualBasic
Imports DataAnnotationAttributes.Model
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq

Namespace DataAnnotationAttributes.ViewModels
	<POCOViewModel> _
	Public Class MainViewModel
		Private ContactContext As ContactContext

		Private privateContacts As IList(Of Contact)
		Public Overridable Property Contacts() As IList(Of Contact)
			Get
				Return privateContacts
			End Get
			Protected Set(ByVal value As IList(Of Contact))
				privateContacts = value
			End Set
		End Property
		Private privateSelectedContact As Contact
		Public Overridable Property SelectedContact() As Contact
			Get
				Return privateSelectedContact
			End Get
			Set(ByVal value As Contact)
				privateSelectedContact = value
			End Set
		End Property

		Protected Sub New()
			If (Not ViewModelBase.IsInDesignMode) Then
				InitializeInRuntime()
			Else
				InitializeInDesingMode()
			End If
		End Sub
		Private Sub InitializeInRuntime()
			ContactContext = New ContactContext()
			ContactContext.Contacts.Load()
			Contacts = ContactContext.Contacts.Local
		End Sub
		Private Sub InitializeInDesingMode()
			Contacts = New List(Of Contact) (New Contact() {New Contact("FirstName", "LastName") With {.Gender = Gender.Female, .Email = "email", .Phone = "(555)555-0000", .Address = "Address", .City = "City", .State = "AA", .Zip = "11111"}})
		End Sub
	End Class
End Namespace