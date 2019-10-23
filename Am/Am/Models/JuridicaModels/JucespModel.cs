using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Models.JuridicaModels
{
     public class JucespModel
    {

        public override string ToString()
        {
            string somaDados = "";

            somaDados = "--------------  DADOS JUCESP ---------------- \n\n\n";
            somaDados += "Nire: " + nire + "\n\n";
            somaDados += "Tipo da empresa: " + tipoEmpresa + "\n\n";
            somaDados += "Data Const: " + dtConst + "\n\n";
            somaDados += "Inicio das atividades: " + inicioAtividade + "\n\n";
            somaDados += "CNPJ: " + cnpj + "\n\n";
            somaDados += "Inscrição Estadual " + incricaoEstadual + "\n\n";
            somaDados += "Descrição da empresa: " + objetoDescricao + "\n\n";
            somaDados += "Capital: " + capital + "\n\n";
            somaDados += "Logradouro: " + logradouro + "\n\n";
            somaDados += "Número: " + numero + "\n\n";
            somaDados += "Bairro: " + bairro + "\n\n";
            somaDados += "Complemento: " + complemento + "\n\n";
            somaDados += "Municipio: " + municipio + "\n\n";
            somaDados += "CEP: " + cep + "\n\n";
            somaDados += "Estado: " + uf + "\n\n\n\n";

            return somaDados;

        }
        public string nire { get; set; }
        public string tipoEmpresa { get; set; }
        public string dtConst { get; set; }
        public string inicioAtividade { get; set; }
        public string cnpj { get; set; }
        public string incricaoEstadual { get; set; }
        public string objetoDescricao { get; set; }
        public string capital { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string municipio { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }

       





    }
}
