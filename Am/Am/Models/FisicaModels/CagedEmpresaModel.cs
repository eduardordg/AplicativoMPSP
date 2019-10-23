using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Am.Models
{
    public class CagedEmpresaModel
    {

        public override string ToString()
        {
            string somaDados = "";

            somaDados = "----  DADOS EMPRESA (CAGED) ---- \n\n\n";
            somaDados += "CNPJ: " + cnpj + "\n\n";
            somaDados += "Razão Social: " + razaoSocial + "\n\n";
            somaDados += "Atividade Econômica: " + atividadeEconomica + "\n\n";
            somaDados += "Numero de filiais: " + numeroFiliais + "\n\n";
            somaDados += "Número total de vínculos: " + totalVinculos + "\n\n";
            somaDados += "Primeiro dia: " + primeiroDia + "\n\n";
            somaDados += "Admissões: " + admissoes + "\n\n";
            somaDados += "Desligamentos: " + desligamentos + "\n\n";
            somaDados += "Ultimo dia: " + ultimoDia + "\n\n";
            somaDados += "Variação absoluta: " + variacaoAbsoluta + "\n\n\n\n";

            return somaDados;

        }

        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string atividadeEconomica { get; set; }
        public string numeroFiliais { get; set; }
        public string totalVinculos { get; set; }
        public string primeiroDia { get; set; }
        public string admissoes { get; set; }
        public string desligamentos { get; set; }
        public string ultimoDia { get; set; }
        public string variacaoAbsoluta { get; set; }



    }
}
