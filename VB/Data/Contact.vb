Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Mvvm
Imports DevExpress.Xpf.Mvvm.DataAnnotations
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Namespace DataAnnotationAttributes.Model
	Public Class Contact
		Private privateId As Integer
        <ReadOnlyAttribute(True)> _
        <Display(AutoGenerateField:=False)> _
        Public Property Id() As Integer
            Get
                Return privateId
            End Get
            Set(ByVal value As Integer)
                privateId = value
            End Set
        End Property

		Private privateGender As Gender
		<Display(GroupName := "General Info", AutoGenerateField := False)> _
		Public Property Gender() As Gender
			Get
				Return privateGender
			End Get
			Set(ByVal value As Gender)
				privateGender = value
			End Set
		End Property

		Private privateFirstName As String
		<Display(GroupName := "General Info"), Required, MaxLength(25, ErrorMessage := "Value is too long")> _
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property

		Private privateLastName As String
		<Display(GroupName := "General Info"), Required> _
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property

		Private privateCreditCardNumber As String
		<Display(GroupName := "General Info"), DisplayFormat(NullDisplayText := "<empty>"), CreditCard> _
		Public Property CreditCardNumber() As String
			Get
				Return privateCreditCardNumber
			End Get
			Set(ByVal value As String)
				privateCreditCardNumber = value
			End Set
		End Property

		Private privateEmail As String
		<Display(GroupName := "Contacts"), DisplayFormat(NullDisplayText := "<empty>"), DataType(DataType.EmailAddress)> _
		Public Property Email() As String
			Get
				Return privateEmail
			End Get
			Set(ByVal value As String)
				privateEmail = value
			End Set
		End Property

		Private privatePhone As String
		<Display(GroupName := "Contacts"), DataType(DataType.PhoneNumber), DisplayFormat(NullDisplayText := "<empty>")> _
		Public Property Phone() As String
			Get
				Return privatePhone
			End Get
			Set(ByVal value As String)
				privatePhone = value
			End Set
		End Property

		Private privateAddress As String
		<Display(GroupName := "Address"), DisplayFormat(NullDisplayText := "<empty>")> _
		Public Property Address() As String
			Get
				Return privateAddress
			End Get
			Set(ByVal value As String)
				privateAddress = value
			End Set
		End Property

        Private privateCity As String
		<Display(GroupName := "Address"), DisplayFormat(NullDisplayText := "<empty>"), RegExMaskAttribute(Mask := "\w{1,25}", UseAsDisplayFormat := True, ShowPlaceHolders := False)> _
		Public Property City() As String
            Get
                Return privateCity
            End Get
            Set(ByVal value As String)
                privateCity = value
            End Set
        End Property

        <Display(GroupName:="Address"), DisplayFormat(NullDisplayText:="<empty>"), CustomValidation(GetType(ContactValidator), "ValidateString")> _
        Public Property State() As String

        <Display(GroupName:="Address"), DisplayFormat(NullDisplayText:="<empty>")> _
        Public Property Zip As String

        <Display(AutoGenerateField:=False), DisplayFormat(NullDisplayText:="<empty>")> _
        Public Property Photo As Byte()

        Public Sub New()
        End Sub

        Public Sub New(ByVal _firstName As String, ByVal _lastName As String)
            FirstName = _firstName
            LastName = _lastName
        End Sub
    End Class
End Namespace
