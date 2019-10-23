    using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Models
{
   public class SielModel
    {

        public override string ToString()
        {
            string somaDados = null;


            somaDados = "----------------------- DADOS SIEL -------------------------  \n\n\n\n";
            somaDados += "Nome: " + nome + "\n\n";
            somaDados += "Título: " + titulo + "\n\n";
            somaDados += "Data de nascimento: " + dtNascimento + "\n\n";
            somaDados += "Zona eleitoral: " + zone + "\n\n";
            somaDados += "Endereço: " + endereco + "\n\n";
            somaDados += "Municipio: " + municipio + "\n\n";
            somaDados += "UF: " + uf + "\n\n";
            somaDados += "Data domicilio: " + dtDomicilio + "\n\n";
            somaDados += "Nome do Pai: " + nomePai + "\n\n";
            somaDados += "Nome da Mãe: " + nomeMae + "\n\n";
            somaDados += "Naturalidade: " + naturalidade + "\n\n";
            somaDados += "Cd Validaçãoo: " + cdValidacao + "\n\n\n";

            return somaDados;

        }

        public string nome { get; set; }
        public string titulo { get; set; }
        public string dtNascimento { get; set; }
        public string zone { get; set; }
        public string endereco { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }
        public string dtDomicilio { get; set; }
        public string nomePai { get; set; }
        public string nomeMae { get; set; }
        public string naturalidade { get; set; }
        public string cdValidacao { get; set; }



    }
}
