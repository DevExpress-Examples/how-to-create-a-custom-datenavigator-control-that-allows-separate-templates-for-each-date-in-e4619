<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DateNavigator/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DateNavigator/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DateNavigator/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DateNavigator/MainWindow.xaml.vb))
* [TemplatedDateNavigator.xaml](./CS/DateNavigator/TemplatedDateNavigator.xaml) (VB: [TemplatedDateNavigator.xaml](./VB/DateNavigator/TemplatedDateNavigator.xaml))
* [TemplatedDateNavigator.xaml.cs](./CS/DateNavigator/TemplatedDateNavigator.xaml.cs) (VB: [TemplatedDateNavigator.xaml.vb](./VB/DateNavigator/TemplatedDateNavigator.xaml.vb))
* [TestSpecialDateTemplateSelector.cs](./CS/DateNavigator/TestSpecialDateTemplateSelector.cs) (VB: [TestSpecialDateTemplateSelector.vb](./VB/DateNavigator/TestSpecialDateTemplateSelector.vb))
<!-- default file list end -->
# How to create a custom DateNavigator control that allows separate templates for each date in a SpecialDates list


<p>This example demonstrates how to create a DateNavigator descendant that allows specifying separate templates for each date in the SpecialDates list.</p><br />
<p>Add a TemplatedDateNavigator control in your project and follow these steps:</p><br />
<p>1. Define templates for special dates:</p>

```xaml
<Window x:Class="dxExample.MainWindow"
    ...
    xmlns:local="clr-namespace:dxExample">
    <Window.Resources>
        <DataTemplate x:Key="testSpecialDateTemplate1">
            <Border BorderBrush="Orange" BorderThickness="2" CornerRadius="2">
                <TextBlock Text="{Binding Day}" Margin="2"/>
            </Border>
        </DataTemplate>
        <DataTemplate x:Key="testSpecialDateTemplate2">
            <Grid>
                <Ellipse Fill="Azure" Width="22" Height="22"/>
                <TextBlock Text="{Binding Day}" VerticalAlignment="Center" HorizontalAlignment="Center" FontStyle="Italic"/>
            </Grid>
        </DataTemplate>
    </Window.Resources>
    ...
</Window>
```

<p> </p><p>2. Create a DataTemplateSelector descendant as shown below:</p>

```cs
public class TestSpecialDateTemplateSelector : DataTemplateSelector {
        public override System.Windows.DataTemplate SelectTemplate(object item, DependencyObject container) {
            DateTime date = (DateTime)item;
            if(date.Day % 2 == 0) return App.Current.MainWindow.FindResource("testSpecialDateTemplate1") as DataTemplate;
            return App.Current.MainWindow.FindResource("testSpecialDateTemplate2") as DataTemplate;
        }
    }
```

<p> </p>

```vb
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
```

<p> </p><p>3. Place your custom DataTemplateSelector to Resources and bind to the TemplatedDateNavigator.SpecialDateTemplateSelector property:</p>

```xaml
<Window x:Class="dxExample.MainWindow"
    xmlns:local="clr-namespace:dxExample">
    <Window.Resources>
        <local:TestSpecialDateTemplateSelector x:Key="testSpecialDateTemplateSelector"/>
        ...
    </Window.Resources>
    <Grid>
        <local:TemplatedDateNavigator SpecialDateTemplateSelector="{DynamicResource testSpecialDateTemplateSelector}"/>
    </Grid>
</Window>
```

<p> </p><p><strong>See also:</strong><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/Q338480">Customize style of SpecialDates in DateNavigator control</a></p>

<br/>


