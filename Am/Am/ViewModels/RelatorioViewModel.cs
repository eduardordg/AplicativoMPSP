using Am.Models;
using Am.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Am.ViewModels
{
    public class RelatorioViewModel : INotifyPropertyChanged
    {

        public RelatorioViewModel()
        {

            //Validação para passagem dos dados da GlobalViewModel para a RelatorioViewModel
            if (GlobalViewModel.Relatorio != null)
            {
                this.Resultado = GlobalViewModel.Relatorio.Resultado;
                this.Image = GlobalViewModel.Relatorio.image;
                this.NomeImage = GlobalViewModel.Relatorio.nomeImage;
                this.Image2 = GlobalViewModel.Relatorio.image2;
                this.NomeImage2 = GlobalViewModel.Relatorio.nomeImage2;
                this.Image3 = GlobalViewModel.Relatorio.image3;
                this.NomeImage3 = GlobalViewModel.Relatorio.nomeImage3;
                GlobalViewModel.Relatorio = null;

            }



        }


        //declaração de atributo
        private string resultado;
        public string Resultado
        {
            get { return resultado; }
            set
            {

                resultado = value;
                NotifyPropertyChanged();


            }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {

                image = value;
                NotifyPropertyChanged();


            }
        }

        private string nomeImage;
        public string NomeImage
        {
            get { return nomeImage; }
            set
            {

                nomeImage = value;
                NotifyPropertyChanged();


            }
        }

        private string image2;
        public string Image2
        {
            get { return image2; }
            set
            {

                image2 = value;
                NotifyPropertyChanged();


            }
        }

        private string nomeImage2;
        public string NomeImage2
        {
            get { return nomeImage2; }
            set
            {

                nomeImage2 = value;
                NotifyPropertyChanged();


            }
        }

        private string image3;
        public string Image3
        {
            get { return image3; }
            set
            {

                image3 = value;
                NotifyPropertyChanged();


            }
        }

        private string nomeImage3;
        public string NomeImage3
        {
            get { return nomeImage3; }
            set
            {

                nomeImage3 = value;
                NotifyPropertyChanged();


            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
