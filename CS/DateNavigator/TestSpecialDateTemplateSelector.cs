using System;
using System.Windows;
using System.Windows.Controls;

namespace dxExample {
    public class TestSpecialDateTemplateSelector : DataTemplateSelector {
        public override System.Windows.DataTemplate SelectTemplate(object item, DependencyObject container) {
            DateTime date = (DateTime)item;
            if(date.Day % 2 == 0) return App.Current.MainWindow.FindResource("testSpecialDateTemplate1") as DataTemplate;
            return App.Current.MainWindow.FindResource("testSpecialDateTemplate2") as DataTemplate;
        }
    }
}
