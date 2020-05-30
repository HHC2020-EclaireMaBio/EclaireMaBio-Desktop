using BioDiag.Pages;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;

namespace BioDiag
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Console.WriteLine("Begin...");
            InitializeComponent();
            Console.WriteLine("Began...");

            //MainNavFrame.Navigate(null);
            //MainNavFrame.Navigate(new DragDropAnalysisPage());
        }

        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            Console.WriteLine("ContentRendered");
            var view = new AuthenticationDialog { };

            await DialogHost.Show(view, "RootDialog");
        }
    }
}
