Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Editors.DateNavigator

Namespace dxExample
	Partial Public Class TemplatedDateNavigator
		Inherits DateNavigator
		Public Property SpecialDateTemplateSelector() As DataTemplateSelector
			Get
				Return CType(GetValue(SpecialDateTemplateSelectorProperty), DataTemplateSelector)
			End Get
			Set(ByVal value As DataTemplateSelector)
				SetValue(SpecialDateTemplateSelectorProperty, value)
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
			SpecialDateTemplateSelector = New DefaultSpecialDateTemplateSelector(Me)
		End Sub

		Public Shared ReadOnly SpecialDateTemplateSelectorProperty As DependencyProperty = DependencyProperty.Register("SpecialDateTemplateSelector", GetType(DataTemplateSelector), GetType(TemplatedDateNavigator), New PropertyMetadata(Nothing))
	End Class

	Public Class DefaultSpecialDateTemplateSelector
		Inherits DataTemplateSelector
		Private defaultSpecialDateTemplate As DataTemplate
		Public Sub New(ByVal ownerNavigator As TemplatedDateNavigator)
			Me.defaultSpecialDateTemplate = TryCast(ownerNavigator.FindResource("defaultSpecialDateTemplate"), DataTemplate)
		End Sub
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Return Me.defaultSpecialDateTemplate
		End Function
	End Class
End Namespace