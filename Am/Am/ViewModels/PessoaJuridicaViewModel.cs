using Am.Layers.Business;
using Am.Layers.Services;
using Am.Models;
using Am.Models.JuridicaModels;
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
    public class PessoaJuridicaViewModel : INotifyPropertyChanged
    {

        public ICommand PesquisarClickedCommand { get; private set; }

        public PessoaJuridicaViewModel()
        {
            PesquisarClickedCommand = new Command(() => {


                var pessoaJuridicaBusiness = new PessoaJuridicaBusiness();  //Instanciando business para acessar a service e pegar dados da api
                var service = pessoaJuridicaBusiness.getService(); //atribuiu o objeto service a uma variavel para fazer as chamadas das API dentros dos IF conforme resultados do Picker
                var relatorio = new RelatorioViewModel(); // instancia relatorio para envio das informações para a tela

                //validação CNPJ NULO
                if (String.IsNullOrEmpty(cnpj) == true)
                {

                    DependencyService.Get<IMessage>().ShortAlert("Por favor digite seu CNPJ");
                }

                else
                {
                    //Validação Picker Nulo
                    if (baseDados == null)
                    {
                        DependencyService.Get<IMessage>().ShortAlert("Por favor selecione ao menos uma base de dados para consulta");
                    }

                    else
                    {

                        if (baseDados == "Todos")
                        {

                            JucespModel jucesp = new JucespModel();
                            jucesp = service.getJucesp(cnpj); 
                            relatorio.Resultado = jucesp.ToString(); 

                            CadespModel cadesp = new CadespModel();
                            cadesp = service.getCadesp(cnpj);
                            relatorio.Resultado += cadesp.ToString();

                            GlobalViewModel.Relatorio = relatorio;// manda os dados para a global, fazendo a RelatorioViewModel enxergar

                            string sourceImage1 = service.getArisp(cnpj);
                            relatorio.NomeImage = "------ARISP----";
                            relatorio.Image = sourceImage1;
                            string sourceImage2 = service.getInfocrim(cnpj);
                            relatorio.NomeImage2 = "------INFOCRIM----";
                            relatorio.Image2 = sourceImage2;

                            GlobalViewModel.Relatorio = relatorio;

                        }


                        if (baseDados == "Jucesp")
                        {
                            JucespModel jucesp = new JucespModel();
                            jucesp = service.getJucesp(cnpj); 
                            relatorio.Resultado = jucesp.ToString(); 
                            GlobalViewModel.Relatorio = relatorio;

                           
                        }

                        if (baseDados == "Cadesp")
                        {
                            CadespModel cadesp = new CadespModel();
                            cadesp = service.getCadesp(cnpj);
                            relatorio.Resultado = cadesp.ToString();
                            GlobalViewModel.Relatorio = relatorio;
                        }


                        if (baseDados == "Arisp")
                        {
                            string sourceImage1 = service.getArisp(cnpj);
                            relatorio.NomeImage = "------ARISP----";
                            relatorio.Image = sourceImage1;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                       

                        if (baseDados == "Infocrim")
                        {
                            string sourceImage2 = service.getInfocrim(cnpj);
                            relatorio.NomeImage2 = "------INFOCRIM----";
                            relatorio.Image2 = sourceImage2;
                            GlobalViewModel.Relatorio = relatorio;
                        }


                        MessagingCenter.Send<PessoaJuridicaViewModel>(this, "RelatorioPageAbrir");

                    }
                }
            
            });

        }

        //Declaração atributos
        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set
            {
                if (cnpj != value)
                {
                    cnpj = value;
                    NotifyPropertyChanged();
                }
            }
        }

        //Declaração atributos que vão receber o valor do Picker das base de dados

        private string baseDados;
        public string BaseDados
        {
            get { return baseDados; }
            set
            {
                if (baseDados != value)
                {
                    baseDados = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
