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
            InitializeComponent();
        }

        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            var view = new AuthenticationDialog { };

            await DialogHost.Show(view, "RootDialog");

            if (view.authDone)
            {
                MainNavFrame.Navigate(null);
                // MainNavFrame.Navigate(new DragDropAnalysisPage());
                MainNavFrame.Navigate(new HomePage());
            }
        }
    }
}
