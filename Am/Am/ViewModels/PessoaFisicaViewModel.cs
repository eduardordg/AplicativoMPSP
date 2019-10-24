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
    public class PessoaFisicaViewModel : INotifyPropertyChanged
    {

        public PessoaFisicaViewModel()
        {


            PesquisarClickedCommand = new Command(() =>
            {

                var pessoaFisicaBusiness = new PessoaFisicaBusiness(); //instancia business para acessar a service
                var service = pessoaFisicaBusiness.getService(); //atribuiu o objeto service a uma variavel para fazer as chamadas das API dentros dos IF conforme resultados do Picker
                var relatorio = new RelatorioViewModel(); // instancia relatorio para envio das informações para a nova tela




                //Validação cpf NULO
                if (String.IsNullOrEmpty(cpf) == true)
                {

                    DependencyService.Get<IMessage>().ShortAlert("Por favor digite seu cpf");
                }

                else
                {
                    //Validação do Picker nulo
                    if (baseDados == null)
                    {
                        DependencyService.Get<IMessage>().ShortAlert("Por favor selecione ao menos uma base de dados para consulta");
                    }

                    else
                    {


                        if (baseDados == "Todos")
                        {
                            CagedAllModel cagedAll = new CagedAllModel();
                            cagedAll = service.getCaged(cpf); //envio dos dados que a instancia da service conseguiu
                            relatorio.Resultado += cagedAll.caged.ToString();
                            relatorio.Resultado += cagedAll.cagedEmpresa.ToString();
                            relatorio.Resultado += cagedAll.cagedTrabalhador.ToString();

                            List<CensecModel> listaCensec = new List<CensecModel>();
                            listaCensec = service.getCensec();
                            foreach (CensecModel censecCont in listaCensec)
                            {
                                relatorio.Resultado += (censecCont.ToString());
                            }


                            List<ArpenpModel> listaArpenp = new List<ArpenpModel>();
                            listaArpenp = service.getArpenp(cpf);
                            foreach (ArpenpModel arpenpCont in listaArpenp)
                            {
                                relatorio.Resultado += (arpenpCont.ToString());
                            }


                            List<SielModel> listaSiel = new List<SielModel>();
                            listaSiel = service.getSiel();
                            foreach (SielModel sielCont in listaSiel)
                            {
                                relatorio.Resultado += (sielCont.ToString());
                            }


                            List<SivecModel> listaSivec = new List<SivecModel>();
                            listaSivec = service.getSivec();
                            foreach (SivecModel sivecCont in listaSivec)
                            {
                                relatorio.Resultado += (sivecCont.ToString());
                            }

                            GlobalViewModel.Relatorio = relatorio;// manda os dados para a global, fazendo a RelatorioViewModel enxergar

                            string sourceImage1 = service.getArisp(cpf);
                            relatorio.NomeImage = "------ARISP----";
                            relatorio.Image = sourceImage1;

                            string sourceDetran1 = "";
                            string sourceDetran2 = "";
                            List<string> listaSource = service.getDetran(cpf);
                            relatorio.NomeImage2 = "------DETRAN----";
                            foreach (string arpenpCont in listaSource)
                            {
                                if (arpenpCont == "detran.jpeg")
                                {
                                    sourceDetran1 = arpenpCont;
                                }

                                if (arpenpCont == "detran2.jpeg")
                                {
                                    sourceDetran2 = arpenpCont;

                                }

                            }
                            relatorio.Image2 = sourceDetran1;
                            relatorio.Image3 = sourceDetran2;
                            GlobalViewModel.Relatorio = relatorio;

                            string sourceImage3 = service.getInfocrim(cpf);
                            relatorio.NomeImage4 = "------INFOCRIM----";
                            relatorio.Image4 = sourceImage3;

                            GlobalViewModel.Relatorio = relatorio;


                        }





                        if (baseDados == "Caged")
                        {
                            CagedAllModel cagedAll = new CagedAllModel();
                            cagedAll = service.getCaged(cpf);
                            relatorio.Resultado += cagedAll.caged.ToString();
                            relatorio.Resultado += cagedAll.cagedEmpresa.ToString();
                            relatorio.Resultado += cagedAll.cagedTrabalhador.ToString();
                            GlobalViewModel.Relatorio = relatorio;// manda os dados para a global, fazendo a RelatorioViewModel enxergar


                        }

                        if (baseDados == "Censec")
                        {
                            List<CensecModel> listaCensec = new List<CensecModel>();
                            listaCensec = service.getCensec();

                            foreach (CensecModel censecCont in listaCensec)
                            {
                                relatorio.Resultado += (censecCont.ToString());
                            }

                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (baseDados == "Arisp")
                        {
                            string sourceImage1 = service.getArisp(cpf);
                            relatorio.NomeImage = "------ARISP----";
                            relatorio.Image = sourceImage1;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (baseDados == "Detran")
                        {

                            List<string> listaSource = service.getDetran(cpf);
                            relatorio.NomeImage2 = "------DETRAN----";
                            string sourceDetran1 = "";
                            string sourceDetran2 = "";
                            foreach (string arpenpCont in listaSource)
                            {
                                if (arpenpCont == "detran.jpeg")
                                {
                                    sourceDetran1 = arpenpCont;
                                }

                                if (arpenpCont == "detran2.jpeg")
                                {
                                    sourceDetran2 = arpenpCont;

                                }

                            }
                            relatorio.Image2 = sourceDetran1;
                            relatorio.Image3 = sourceDetran2;

                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (baseDados == "Infocrim")
                        {
                            string sourceImage4 = service.getInfocrim(cpf);
                            relatorio.NomeImage4 = "------INFOCRIM----";
                            relatorio.Image4 = sourceImage4;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (baseDados == "Arpenp")
                        {
                            List<ArpenpModel> listaArpenp = new List<ArpenpModel>();
                            listaArpenp = service.getArpenp(cpf);
                            foreach (ArpenpModel arpenpCont in listaArpenp)
                            {
                                relatorio.Resultado += (arpenpCont.ToString());
                            }
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (baseDados == "Siel")
                        {

                            List<SielModel> listaSiel = new List<SielModel>();
                            listaSiel = service.getSiel();

                            foreach (SielModel sielCont in listaSiel)
                            {
                                relatorio.Resultado += (sielCont.ToString());
                            }

                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (baseDados == "Sivec")
                        {
                            List<SivecModel> listaSivec = new List<SivecModel>();
                            listaSivec = service.getSivec();

                            foreach (SivecModel sivecCont in listaSivec)
                            {
                                relatorio.Resultado += (sivecCont.ToString());
                            }

                            GlobalViewModel.Relatorio = relatorio;
                        }



                        MessagingCenter.Send<PessoaFisicaViewModel>(this, "RelatorioPageAbrir");

                    }
                }

            });

        }



        //Declaração atributos
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set
            {
                if (cpf != value)
                {
                    cpf = value;
                    NotifyPropertyChanged();
                }
            }
        }

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


        //Atributo que vai pra tela, com as informações da api
        private string resultado;
        public string Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    NotifyPropertyChanged();
                }
            }
        }


        //Declaração command para pesquisar
        public ICommand PesquisarClickedCommand { get; private set; }




        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
