using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Testmysql2.NewFolder1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testmysql2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*if(verificarBaseDatos())llenarusers();
            else
            {
                DisplayAlert("Mensaje", "No Hay Conexion con la BD. Esta en Mantenimiento", "OK");
                Application.Kill.Process;
            }*/
            llenarUsers();
            
        }
        private async void llenarUsers()
        {
            try
            {
                UserManager manager = new UserManager();
                var res = await manager.getUsuarios();
                if(res!=null)
                {
                    lstUser.ItemsSource = res;
                }
            }
            catch(Exception e)
            {

            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtuser.Text))
            {

            }
            else if (string.IsNullOrEmpty(txtpass.Text))
            {

            }
            else
            { 
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("nombre", txtuser.Text);
                parametros.Add("clave", txtpass.Text);

                byte[] response = cliente.UploadValues("http://192.168.1.10/webservice2/insertUser.php","POST",parametros);
                string c = Encoding.ASCII.GetString(response);
                if(c.Equals("1"))
                {
                    DisplayAlert("Informacion", "Usuario Guardado Satisfactoriamente", "OK");
                    txtuser.Text = "";
                    txtpass.Text = "";
                }
                else
                {
                    DisplayAlert("Informacion", "Error al Guardar Usuario", "OK");
                }
            }

        }
    }
}