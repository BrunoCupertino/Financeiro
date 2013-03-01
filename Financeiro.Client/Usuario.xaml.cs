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
using System.Windows.Shapes;
using Base.Server.Model;
using Financeiro.Server.DataController;

namespace Financeiro.Client
{
    /// <summary>
    /// Interaction logic for Usuario.xaml
    /// </summary>
    public partial class Usuario : Window
    {
        private DCUser controller;
        private StateView state;
        public User user;

        public Usuario(StateView state)
        {
            InitializeComponent();
            this.state = state;
            user = new User();
            controller = new DCUser();
            this.DataContext = user;
            ConfigureView();
            SetBindings();

            this.Owner = Application.Current.MainWindow;
        }

        public Usuario(StateView state, User user)
            : this(state)
        {
            this.user = user;
            this.DataContext = user;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Client.RemoveWindows();
        }

        private void SetBindings()
        {
            txtEmail.SetBinding(TextBox.TextProperty, "Email");
            txtNome.SetBinding(TextBox.TextProperty, "FirstName");
            txtSobrenome.SetBinding(TextBox.TextProperty, "LastName");
            txtSenha.SetBinding(TextBox.TextProperty, "Password");
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //controller.Save(user);
                //MessageBox.Show("Usuário incluido com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigureView()
        {
            if (state == StateView.New)
            {
                btnExcluir.IsEnabled = false;
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller.Delete(user);
                MessageBox.Show("Usuário excluido com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
