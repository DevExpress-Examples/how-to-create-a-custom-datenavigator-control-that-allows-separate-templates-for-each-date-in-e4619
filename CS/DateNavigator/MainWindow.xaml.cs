
using System;
using System.Windows;

namespace dxExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            this.dateNavigator.SpecialDates.Add(DateTime.Now.AddDays(1.0));
            this.dateNavigator.SpecialDates.Add(DateTime.Now.AddDays(2.0));
            this.dateNavigator.SpecialDates.Add(DateTime.Now.AddDays(3.0));
        }
    }
}
