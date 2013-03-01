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
using Financeiro.Server.DataController;
using Financeiro.Server.DataFilter;
using Base.Server.Model;

namespace Financeiro.Client
{
    /// <summary>
    /// Interaction logic for Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Window
    {
        DCUser controller;
        DFUser filter;
        User usuarioSelecionado;

        public Usuarios()
        {
            InitializeComponent();
            controller = new DCUser();
            filter = new DFUser();
            this.DataContext = filter;
            SetBindings();

            this.Owner = Application.Current.MainWindow;
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            lstUsuarios.ItemsSource = controller.GetAll(filter);
        }

        private void SetBindings()
        {
            txtEmail.SetBinding(TextBox.TextProperty, "Email");
            txtNome.SetBinding(TextBox.TextProperty, "FirstName");
            txtSobrenome.SetBinding(TextBox.TextProperty, "LastName");
        }

        private void tbNovo_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Usuario usuario = new Usuario(StateView.New);
            usuario.Show();
        }

        private void lstUsuarios_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            usuarioSelecionado = (User)lstUsuarios.SelectedItem;

            User usuarioCopiado = new User(); 
            Helper.CopyOfType<User>(usuarioSelecionado, usuarioCopiado);

            Usuario usuario = new Usuario(StateView.Edit, usuarioCopiado);
            usuario.Show();
            usuario.Closed += new EventHandler(usuario_Closed);
        }

        void usuario_Closed(object sender, EventArgs e)
        {
            User userRet;
            userRet = (sender as Usuario).user;

            Helper.CopyOfType<User>(userRet, usuarioSelecionado);
        }
    }
}
