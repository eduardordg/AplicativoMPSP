﻿using Am.Models;
using Am.Models.JuridicaModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Am.Layers.Services
{
   public class PessoaJuridicaService
    {

        public JucespModel getJucesp(string cnpj)
        {
            string uri = "http://10.0.2.2:8080/jucesp/cnpj?cnpj=" + cnpj;
            JucespModel jucesp = new JucespModel();           


            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                jucesp = JsonConvert.DeserializeObject<JucespModel>(resultado); 
                return jucesp;
            }
            else
            {
                throw new Exception("Dados não encontrados");
            }
        }

        public CadespModel getCadesp(string cnpj)
        {
            string uri = "http://10.0.2.2:8080/cadesp/cnpj?cnpj=" + cnpj;
            CadespModel cadesp = new CadespModel();


            System.Net.Http.HttpClient client = new HttpClient();
            var resposta = client.GetAsync(uri).Result;
            if (resposta.IsSuccessStatusCode)
            {
                var resultado = resposta.Content.ReadAsStringAsync().Result;
                cadesp = JsonConvert.DeserializeObject<CadespModel>(resultado);
                return cadesp;
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



        public string getInfocrim(string cpf) 
        {
            string sourceImage = "infocrim.jpeg";


            return sourceImage;
        }

    }
}
