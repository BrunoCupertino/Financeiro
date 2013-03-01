using System;
using System.Collections.Generic;
using System.Linq;
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
using Financeiro.Server.DataFilter;
using Base.Server.Model;
using Financeiro.Server.DataController;
using Base.Server.Session;

namespace Financeiro.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DCUser controller;
        DFUser filter = new DFUser();

        public MainWindow()
        {
            InitializeComponent();
            SetBindings();
            txtUsuario.Focus();

            this.DataContext = filter;
            controller = new DCUser();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller.LogOn(filter);

                if (Session.IsLogged)
                {
                    Main main = new Main();
                    App.Current.MainWindow = main;
                    main.Show();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetBindings()
        {
            txtUsuario.SetBinding(TextBox.TextProperty, "Email");
            txtSenha.SetBinding(TextBox.TextProperty, "Password");
        }
    }
}
