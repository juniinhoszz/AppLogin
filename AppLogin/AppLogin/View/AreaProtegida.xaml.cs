using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppLogin.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AreaProtegida : ContentPage
    {
        App PropriedadeApp;
        public AreaProtegida()
        {
            InitializeComponent();
            PropriedadeApp = (App)Application.Current;

            string email_login = PropriedadeApp.Properties["usuario_logado"].ToString();

            DadosUsuario usuario_logado = PropriedadeApp.lista_usuarios.FirstOrDefault(i => i.Email == email_login);

            lbl_boasvindas.Text = "Bem-vindo(a) " + usuario_logado.Nome;
            
        }

        private async void btnDesconectar_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool confirm = await DisplayAlert("Tem Certeza?", "Vai fazer o logoff da sua conta?", "Sim", "Não");

                if (confirm)
                {
                    App.Current.Properties.Remove("usuario_logado");

                    App.Current.MainPage = new Login();
                }
                else throw new Exception("Falha ao fazer logoff");


            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            

            
        }
    }
}