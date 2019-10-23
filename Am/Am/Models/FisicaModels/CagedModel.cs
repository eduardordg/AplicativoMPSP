using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Am.Models
{
    public class CagedModel
    {

        public override string ToString()
        {
            string somaDados = null;

            somaDados = "---------------- DADOS GERAIS CAGED ----------------  \n\n\n\n";
            somaDados += "Razão social: " + razaoSocial + "\n \n";
            somaDados += "Logradouro: " + logradouro + "\n \n";
            somaDados += "Bairro: " + bairoo + "\n \n";
            somaDados += "Município: " + municipio + "\n \n";
            somaDados += "Estado: " + uf + "\n \n";
            somaDados += "CEP: " + cep + "\n \n";
            somaDados += "Nome: " + nome + "\n \n";
            somaDados += "CPF: " + cpf + "\n \n";
            somaDados += "Telefone: " + telefone + "\n \n";
            somaDados += "Ramal: " + ramal + "\n \n";
            somaDados += "Email: " + email + "\n \n";
            somaDados += "CNPJ: " + cnpjCeiCpf + "\n \n\n\n";

            return somaDados;

        }

        public string razaoSocial { get; set; }
        public string logradouro { get; set; }
        public string bairoo { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string ramal { get; set; }
        public string email { get; set; }
        public string cnpjCeiCpf { get; set; }
       
      

    }
}
