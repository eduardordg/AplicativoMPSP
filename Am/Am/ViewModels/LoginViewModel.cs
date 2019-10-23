﻿using Am.Layers.Business;
using Am.Models;
using Am.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Am.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        

        public LoginViewModel()
        {




            EntrarClickedCommand = new Command(() => {

                var usuarioBusiness = new UsuarioBusiness();

                //Validações para login 
                //Em breve vou refatorar esse grupo de validações em um método :)


                if (String.IsNullOrEmpty(user) == false)
                {
                    if (String.IsNullOrEmpty(password) == false)
                    {

                        if (usuarioBusiness.GetLogin(user, password) == true)
                        {

                            MessagingCenter.Send<LoginViewModel>(this, "LoginSucesso");
                            DependencyService.Get<IMessage>().ShortAlert("Bem vindo senhor(a) Investigador(a)");
                            

                        }
                        else
                        {

                            DependencyService.Get<IMessage>().ShortAlert("Acesso inválido - Dados incorretos");
                        }

                    }
                    else
                    {

                        DependencyService.Get<IMessage>().ShortAlert("Por favor digite a sua senha");
                    }
                }
                else
                {

                    DependencyService.Get<IMessage>().ShortAlert("Por favor digite o seu usuário");
                }


            });
        }





        private string user;
        public string User
        {
            get { return user; }
            set
            {
                if (user != value)
                {
                    user = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public ICommand EntrarClickedCommand { get; private set; }


       

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

       
    
}