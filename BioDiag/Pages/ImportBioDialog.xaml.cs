using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
    /// Logique d'interaction pour ImportBioDialog.xaml
    /// </summary>
    public partial class ImportBioDialog : UserControl
    {
        public bool analysisDone = false;
        public ImportBioDialog()
        {
            InitializeComponent();
        }

        private async void AnalysisDropped(object sender, DragEventArgs e)
        {
            dragdrop.Visibility = Visibility.Hidden;
            loading.Visibility = Visibility.Visible;

            await Task.Delay(3000);

            analysisDone = true;
            MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand.Execute(null, null);
        }
    }
}
