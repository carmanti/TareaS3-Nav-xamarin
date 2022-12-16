using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nav_Layouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnAbrirVentanaDos_Clicked(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String pass = txtPass.Text;

            await Navigation.PushAsync(new Ventana_Dos(user, pass));
        }
    }
}
