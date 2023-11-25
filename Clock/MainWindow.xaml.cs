using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();

            // Initialize and start the clock
            timer = new Timer(TimerCallback, null, 0, 1000);
        }
        private void TimerCallback(object state)
        {
            // Update the digital clock text on the UI thread
            Dispatcher.Invoke(() => digitalClock.Text = DateTime.Now.ToString("HH:mm:ss"));
        }
    
    }
}
