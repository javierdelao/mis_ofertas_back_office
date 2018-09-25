using System;
using System.Collections.Generic;
using System.Linq;
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
using clases.Clases;
using WpfApp1.Pages;
using Newtonsoft.Json;
using System.Net;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Lógica de interacción para pgLogin.xaml
    /// </summary>
    public partial class pgLogin : Page
    {
        public pgLogin()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            
            String rut = tbx_rut.Text;
            String password = tbx_password.Text;

             String url = "http://localhost:8181/api/login/" + rut + "/" + password;
             var json = new WebClient().DownloadString(url);
             LoginResponse response= JsonConvert.DeserializeObject<LoginResponse>(json);
            
            if (response.status.Equals("success"))
            {
                NavigationService.Navigate(new pgHome());
            }
            else
            {
                this.tbl_error.Text = "Credenciales invalidas";
            }
            
        }
    }
}
