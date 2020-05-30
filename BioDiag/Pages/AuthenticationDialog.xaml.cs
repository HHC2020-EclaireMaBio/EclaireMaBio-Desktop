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
        public bool authDone;
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

            // if (LoginTextBox.Text == "JDC" && PasswdTextBox.Password == "aaa")
            if (LoginTextBox.Text.Length >= 3 && PasswdTextBox.Password.Length >= 3)
            {
                authDone = true;
                MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand.Execute(null, null);
            }
            else
            {
                AuthErrorTextBox.Visibility = Visibility.Visible;
                AuthErrorTextBox.Text = "Identifiant / Mot de passe non reconnus";
                return;
            }
        }
    }
}
