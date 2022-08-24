using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using AppLogin.View;
using AppLogin.Model;

namespace AppLogin
{
    public partial class App : Application
    {
        public List<DadosUsuario> lista_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "prof@etec",
                Nome = "Professor",
                Senha = "456"
            },
            new DadosUsuario()
            {
                Email = "rodrigo@etec",
                Nome = "Rodrigo",
                Senha = "rodrigo123"
            },
            new DadosUsuario()
            {
                Email = "pepagay@xvideos.com",
                Nome = "Pepa Broxa",
                Senha = "pepabroxa"
            }
        };

        public App()
        {
            InitializeComponent();

           if (Properties.ContainsKey("usuario_logado"))
                MainPage = new View.AreaProtegida();
            else
                MainPage = new View.Login();

            //MainPage = new MainPage();
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
