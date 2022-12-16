using Xamarin.Forms;

namespace Nav_Layouts
{
    internal class Ventana_Dos : Page
    {
        private string user;
        private string pass;

        public Ventana_Dos(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
    }
}