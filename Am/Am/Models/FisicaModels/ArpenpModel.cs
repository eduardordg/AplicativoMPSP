using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Models.JuridicaModels
{
    public class ArpenpModel
    {


        public override string ToString()
        {
            string somaDados = "";

            somaDados = "--------------  DADOS ARPENP  ---------------- \n\n\n";
            somaDados += "Cartorio: " + cartorio + "\n\n";
            somaDados += "CNS: " + cns+ "\n\n";
            somaDados += "Estado: " + uf+ "\n\n";
            somaDados += "Conjuge 1: " + conjuge + "\n\n";
            somaDados += "Novo conjuge: " + conjugeNovoNome+ "\n\n";
            somaDados += "Conjuge 2: " + conjuge2+ "\n\n";
            somaDados += "Novo conjuge: " + conjuge2NovoNome+ "\n\n";
            somaDados += "Data do casamento: " + dtCasamento+ "\n\n";
            somaDados += "Matricula: " + matricula+ "\n\n";
            somaDados += "Data de entrada: " + dtEntrada + "\n\n";
            somaDados += "Data do registro: " + dtRegistro+ "\n\n";
            somaDados += "Acervo: " + acervo+ "\n\n";
            somaDados += "Número do livro: " + numeroLivro+ "\n\n";
            somaDados += "Número da folha: " + numeroFolha+ "\n\n";
            somaDados += "Número do registro: " + numeroRegistro+ "\n\n\n\n";

            return somaDados;

        }

        public string cartorio { get; set; }
        public string cns { get; set; }
        public string uf { get; set; }
        public string conjuge { get; set; }
        public string conjugeNovoNome { get; set; }
        public string conjuge2 { get; set; }
        public string conjuge2NovoNome { get; set; }
        public string dtCasamento { get; set; }
        public string matricula { get; set; }
        public string dtEntrada { get; set; }
        public string dtRegistro { get; set; }
        public string acervo { get; set; }
        public string numeroLivro { get; set; }
        public string numeroFolha { get; set; }
        public string numeroRegistro { get; set; }
        public string tipoLivro { get; set; }



    }
}
