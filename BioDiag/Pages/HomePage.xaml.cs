using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BioDiag.Pages
{
    /// <summary>
    /// Logique d'interaction pour HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void ImportButton_OnClick(object sender, RoutedEventArgs e)
        {
            var view = new ImportBioDialog { };

            await DialogHost.Show(view, "RootDialog");

            if (view.analysisDone)
            {
                HomeNavFrame.Navigate(null);
                HomeNavFrame.Navigate(new ShowResult());
                //HomeNavFrame.Navigate(new DragDropAnalysisPage());
            }
        }
    }
}
