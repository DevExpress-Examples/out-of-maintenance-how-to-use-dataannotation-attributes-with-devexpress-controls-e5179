Imports Microsoft.VisualBasic
Imports DataAnnotationAttributes.Model
Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Media

Namespace DataAnnotationAttributes.Common
	Public Class GenderToGlyphConverter
		Implements IValueConverter
		Private privateMaleGlyph As ImageSource
		Public Property MaleGlyph() As ImageSource
			Get
				Return privateMaleGlyph
			End Get
			Set(ByVal value As ImageSource)
				privateMaleGlyph = value
			End Set
		End Property
		Private privateFemaleGlyph As ImageSource
		Public Property FemaleGlyph() As ImageSource
			Get
				Return privateFemaleGlyph
			End Get
			Set(ByVal value As ImageSource)
				privateFemaleGlyph = value
			End Set
		End Property
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim _gender As Nullable(Of Gender) = DirectCast(value, Nullable(Of Gender))
            If Not _gender.HasValue Then
                _gender = DirectCast(parameter, Nullable(Of Gender))
            End If
            If Not _gender.HasValue Then
                Return Nothing
            End If
            Return If(_gender.GetValueOrDefault() = Gender.Female, FemaleGlyph, MaleGlyph)
        End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
