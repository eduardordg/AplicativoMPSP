﻿using Am.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Am.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        protected LoginViewModel loginViewModel;
        public LoginPage()
        {
            InitializeComponent();
            
        }
      
      
    }
}