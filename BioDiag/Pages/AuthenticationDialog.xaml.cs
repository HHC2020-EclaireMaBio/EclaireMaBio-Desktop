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
    /// Logique d'interaction pour AuthenticationDialog.xaml
    /// </summary>
    public partial class AuthenticationDialog : UserControl
    {
        public AuthenticationDialog()
        {
            InitializeComponent();
        }

        private void SignInButton_OnClick(object sender, RoutedEventArgs e)
        {
            AuthErrorTextBox.Visibility = Visibility.Hidden;

            if (LoginTextBox.Text == string.Empty)
            {
                AuthErrorTextBox.Visibility = Visibility.Visible;
                AuthErrorTextBox.Text = "Identifiant non renseigné";
                return;
            }
            else if (PasswdTextBox.Password == string.Empty)
            {
                AuthErrorTextBox.Visibility = Visibility.Visible;
                AuthErrorTextBox.Text = "Mot de passe non renseigné";
                return;
            }
        }
    }
}
