Imports Microsoft.VisualBasic
Imports DataAnnotationAttributes.Model
Imports System.Data.Entity
Imports System.Windows

Namespace DataAnnotationAttributes
	Partial Public Class App
		Inherits Application
		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			Database.SetInitializer(Of ContactContext)(New ContactContextInitializer())
			MyBase.OnStartup(e)
		End Sub
	End Class
End Namespace
