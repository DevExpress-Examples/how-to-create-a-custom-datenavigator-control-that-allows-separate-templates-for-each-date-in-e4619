Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace dxExample
	Public Class TestSpecialDateTemplateSelector
		Inherits DataTemplateSelector
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As System.Windows.DataTemplate
			Dim [date] As DateTime = CDate(item)
			If [date].Day Mod 2 = 0 Then
				Return TryCast(App.Current.MainWindow.FindResource("testSpecialDateTemplate1"), DataTemplate)
			End If
			Return TryCast(App.Current.MainWindow.FindResource("testSpecialDateTemplate2"), DataTemplate)
		End Function
	End Class
End Namespace
