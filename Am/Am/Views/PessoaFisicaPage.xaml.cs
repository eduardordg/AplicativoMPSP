﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Am.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PessoaFisicaPage : ContentPage
    {
        public PessoaFisicaPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            

    }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

        }

    }
}