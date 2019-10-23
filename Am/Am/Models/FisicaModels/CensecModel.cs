using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Am.Models
{
   public class CensecModel
    {
        public CensecModel()
        {
   
        }

        public string carga { get; set; }
        public string dtMesAno { get; set; }
        public string ato { get; set; }
        public string dtAto { get; set; }
        public string livro { get; set; }
        public string complemento { get; set; }
        public string folha { get; set; }

        public List<string> nome { get; set; }
        public List<string> cpfCnpj { get; set; }
        public List<string> qualidade { get; set; }
        public string uf { get; set; }
        public string municipio { get; set; }
        public string cartorio { get; set; }
        public List<string> telefone { get; set; }
        public List<string> tipo { get; set; }
        public List<string> ramal { get; set; }
        public List<string> contato { get; set; }
        public List<string> status { get; set; }


        public override string ToString()
        {
            string somaDados = null;

            somaDados = "--------------- DADOS CENSEC ---------------  \n\n\n\n";
            somaDados += "Carga: " + carga + "\n\n";
            somaDados += "Data: " + dtMesAno + "\n\n";
            somaDados += "Ato: " + ato + "\n\n";
            somaDados += "Data do Ato: " + dtAto + "\n\n";
            somaDados += "Livro: " + livro + "\n\n";
            somaDados += "Complemento: " + complemento + "\n\n";
            somaDados += "Folha: " + folha + "\n\n";


            String[] nameArray = nome.ToArray();
            for (int i =0; i < nameArray.Length; i++)
            {
            somaDados += "Nome: " + nameArray.GetValue(i) + "\n\n";
            }

            String[] cpfArray = cpfCnpj.ToArray();
            for (int i = 0; i < cpfArray.Length; i++)
            {
                somaDados += "CPF: " + cpfArray.GetValue(i) + "\n\n";
            }

            String[] qualidadeArray = qualidade.ToArray();
            for (int i = 0; i < qualidadeArray.Length; i++)
            {
                somaDados += "Qualidade: " + qualidadeArray.GetValue(i) + "\n\n";
            }

            somaDados += "Estado: " + uf + "\n\n";
            somaDados += "Municipio: " + municipio + "\n\n";
            somaDados += "Cartorio: " + cartorio + "\n\n";

            String[] telArray = telefone.ToArray();
            for (int i = 0; i < telArray.Length; i++)
            {
                somaDados += "Telefone: " + telArray.GetValue(i) + "\n\n";
            }

            String[] tipoArray = tipo.ToArray();
            for (int i = 0; i < tipoArray.Length; i++)
            {
                somaDados += "Tipo: " + tipoArray.GetValue(i) + "\n\n";
            }

            String[] ramalArray = ramal.ToArray();
            for (int i = 0; i < ramalArray.Length; i++)
            {
                somaDados += "Ramal: " + ramalArray.GetValue(i) + "\n\n";
            }

            String[] contatoArray = contato.ToArray();
            for (int i = 0; i < contatoArray.Length; i++)
            {
                somaDados += "Contato: " + contatoArray.GetValue(i) + "\n\n";
            }

            String[] statusArray = status.ToArray();
            for (int i = 0; i < statusArray.Length; i++)
            {
                somaDados += "Status: " + statusArray.GetValue(i) + "\n\n";
            }
           

            return somaDados;
        }




      
        
    }
}
