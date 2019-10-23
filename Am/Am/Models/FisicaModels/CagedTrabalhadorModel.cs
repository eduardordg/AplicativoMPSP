using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Am.Models
{
    public class CagedTrabalhadorModel
    {
        public override string ToString()
        {
            string somaDados = "";

            somaDados = "---DADOS TRABALHADOR (CAGED) --- \n\n\n";
            somaDados += "Nome: " + nome + "\n \n";
            somaDados += "PIS: " + pis + "\n \n";
            somaDados += "PIS Convertido " + pisConvertido + "\n \n";
            somaDados += "CPF: " + cpf + "\n\n";
            somaDados += "Data de nascimento: " + dtNascimento + "\n \n";
            somaDados += "CTPS: " + ctps + "\n \n";
            somaDados += "Estado: " + uf + "\n \n";
            somaDados += "Situação PIS: " + situacaoPis + "\n\n";
            somaDados += "Sexo: " + sexo + "\n\n";
            somaDados += "Nacionalidade: " + nacionalidade + "\n\n";
            somaDados += "Raça/cor: " + racaCor + "\n \n";
            somaDados += "Grau de instituição: " + grauInstituicao + "\n\n";
            somaDados += "Possuidor de deficiência: " + possuiDeficiencia + "\n\n";
            somaDados += "CEP: " + cep + "\n\n";
            somaDados += "Caged: " + caged + "\n\n";
            somaDados += "Rais: " + rais + "\n\n\n\n";

            return somaDados;

        }

        public string nome { get; set; }
        public string pis { get; set; }
        public string pisConvertido { get; set; }
        public string cpf { get; set; }
        public string dtNascimento { get; set; }
        public string ctps { get; set; }
        public string uf { get; set; }
        public string situacaoPis { get; set; }
        public string sexo { get; set; }
        public string nacionalidade { get; set; }
        public string racaCor { get; set; }
        public string grauInstituicao { get; set; }
        public string possuiDeficiencia { get; set; }
        public string cep { get; set; }
        public string caged { get; set; }
        public string rais { get; set; }
        
       
    }
}
