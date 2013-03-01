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

namespace Financeiro.Client
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void miConfiguracaoFornecedor_Click(object sender, RoutedEventArgs e)
        {
        }

        private void mifConfiguracaoUsuario_Click(object sender, RoutedEventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }
    }
}
