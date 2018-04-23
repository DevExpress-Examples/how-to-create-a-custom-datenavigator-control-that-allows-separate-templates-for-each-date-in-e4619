Imports Microsoft.VisualBasic
Imports System
Imports System.Windows

Namespace dxExample
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Me.dateNavigator.SpecialDates.Add(DateTime.Now.AddDays(1.0))
			Me.dateNavigator.SpecialDates.Add(DateTime.Now.AddDays(2.0))
			Me.dateNavigator.SpecialDates.Add(DateTime.Now.AddDays(3.0))
		End Sub
	End Class
End Namespace
