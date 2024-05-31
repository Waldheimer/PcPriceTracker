using CommunityToolkit.Mvvm.Messaging;
using System.Windows;
using PcPriceTracker.Messages;

namespace PcPriceTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //  *************************************
        //  Send an ApplicationSizeMessage with the current Window Size whenever the Size 
        //  of the current Window changes : Mainly for Debugging Reasons in Responsive Desing
        //  *************************************
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WeakReferenceMessenger.Default.Send(new ApplicationSizeMessage(e.NewSize));
        }
    }
}