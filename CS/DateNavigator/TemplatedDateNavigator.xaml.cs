using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Editors.DateNavigator;

namespace dxExample {
    public partial class TemplatedDateNavigator : DateNavigator {
        public DataTemplateSelector SpecialDateTemplateSelector {
            get { return (DataTemplateSelector)GetValue(SpecialDateTemplateSelectorProperty); }
            set { SetValue(SpecialDateTemplateSelectorProperty, value); }
        }

        public TemplatedDateNavigator() {
            InitializeComponent();
            SpecialDateTemplateSelector = new DefaultSpecialDateTemplateSelector(this);
        }

        public static readonly DependencyProperty SpecialDateTemplateSelectorProperty = DependencyProperty.Register("SpecialDateTemplateSelector", typeof(DataTemplateSelector), typeof(TemplatedDateNavigator), new PropertyMetadata(null));
    }

    public class DefaultSpecialDateTemplateSelector : DataTemplateSelector {
        DataTemplate defaultSpecialDateTemplate;
        public DefaultSpecialDateTemplateSelector(TemplatedDateNavigator ownerNavigator) {
            this.defaultSpecialDateTemplate = ownerNavigator.FindResource("defaultSpecialDateTemplate") as DataTemplate;
        }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            return this.defaultSpecialDateTemplate;
        }
    }
}