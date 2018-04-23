using System.Windows.Controls;

namespace LinearGaugeControl_CustomElement {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.Windows.RoutedEventArgs e) {
            if (bar.Value < 100)
                bar.Value += 10;
        }

        private void button2_Click(object sender, System.Windows.RoutedEventArgs e) {
            if (bar.Value > 0)
                bar.Value -= 10;
        }
    }
}
