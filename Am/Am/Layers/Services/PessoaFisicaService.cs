﻿using Am.Models;
using Am.Models.JuridicaModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace Am.Layers.Services
{
    public class PessoaFisicaService
    {

        //Mock de chamadas da api, enquanto ela não fica pronta :)


        public CagedAllModel getCaged(string cpf)
        {
            string uri = "http://10.0.2.2:8080/caged/cpf?cpf=" + cpf; //não pode ser 127.0.0.1 pq ta sendo executado em Maquina Virtual, logo esse endereço acaba sendo o proprio loopback, por isso o 10.0.2.2
            CagedAllModel cagedAll = new CagedAllModel();


            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {

                var resultado = resposta.Content.ReadAsStringAsync().Result;
                cagedAll = JsonConvert.DeserializeObject<CagedAllModel>(resultado); // Não sei como fazer com string, no exemplo do professor ele usar objeto.
                //dados = Convert.ToString(obj);
                return cagedAll;
            }
            else
            {
                throw new Exception("Dados não encontrados");
            }
        }




        public List<CensecModel> getCensec()
        {
            string uri = "http://10.0.2.2:8080/censec/";//também não busca por cpf 
            List<CensecModel> censec = new List<CensecModel>();



            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                censec = JsonConvert.DeserializeObject<List<CensecModel>>(resultado); // Não sei como fazer com string, no exemplo do professor ele usar objeto.
                
                return censec;
            }
            else
            {
                throw new Exception("Dados não encontrados");
            }
        }


        public string getArisp(string cpf) 
        {
            string sourceImage = "arisp.jpeg";


            return sourceImage;
        }


        public string getDetran(string cpf) //IMAGE
        {
           string sourceImage = "detran.jpeg";


            return sourceImage;
        }


        public string getInfocrim(string cpf) //IMAGE
        {
            string sourceImage = "infocrim.jpeg";


            return sourceImage;
        }

        public List<ArpenpModel> getArpenp(string cpf)
        {
            string uri = "http://10.0.2.2:8080/arpend/";
            List<ArpenpModel> arpenp = new List<ArpenpModel>();

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                arpenp = JsonConvert.DeserializeObject<List<ArpenpModel>>(resultado); 
                return arpenp;
            }
            else
            {
                throw new Exception("Dados não encontrados");
            }
        }


        public List<SielModel> getSiel()
        {
            string uri = "http://10.0.2.2:8080/siel/"; //esse portal não busca pelo cpf
                                                       // SielModel siel = new SielModel();
            List<SielModel> siel = new List<SielModel>();

            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                siel = JsonConvert.DeserializeObject<List<SielModel>>(resultado); // Não sei como fazer com string, no exemplo do professor ele usar objeto.
                return siel;
            }
            else
            {
                throw new Exception("Dados não encontrados");
            }
        }

        public List<SivecModel> getSivec()
        {
            string uri = "http://10.0.2.2:8080/sivec/"; //esse portal não busca por cpf
            List<SivecModel> sivec = new List<SivecModel>();


            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                sivec = JsonConvert.DeserializeObject<List<SivecModel>>(resultado); // Não sei como fazer com string, no exemplo do professor ele usar objeto.
                return sivec;
            }
            else
            {
                throw new Exception("Dados não encontrados");
            }
        }




    }
}

