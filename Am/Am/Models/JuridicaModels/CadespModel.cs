using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Models.JuridicaModels
{
   public class CadespModel
    {

        public override string ToString()
        {
            string somaDados = "";

            somaDados = "--------------  DADOS CADESP ---------------- \n\n\n";
            somaDados += "IE: " + ie + "\n\n";
            somaDados += "CNPJ: " + cnpj + "\n\n";
            somaDados += situacao + "\n\n";
            somaDados += dtInscricaoEstado + "\n\n";
            somaDados += "Nome Empresarial: " + nomeEmpresarial+ "\n\n";
            somaDados += regimeEstadual + "\n\n";
            somaDados += "DRT: " + drt+ "\n\n";
            somaDados += postoFiscal + "\n\n";
            somaDados += "Data Inscrição Estadual: "+ dtInicioIE+ "\n\n";
            somaDados += "Nire: " + nire + "\n\n";
            somaDados += "Ocorrência Fiscal: " + ocorrenciaFiscal + "\n\n";
            somaDados += "Tipo da unidade: " + tipoUnidade + "\n\n";
            somaDados += "Forma de atuação: " + formaAtuacao + "\n\n\n";


            return somaDados;

        }

        public string ie { get; set; }
        public string cnpj { get; set; }
        public string situacao { get; set; }
        public string dtInscricaoEstado { get; set; }
        public string nomeEmpresarial { get; set; }
        public string regimeEstadual { get; set; }
        public string drt { get; set; }
        public string postoFiscal { get; set; }
        public string dtInicioIE { get; set; }
        public string nire { get; set; }
        public string ocorrenciaFiscal { get; set; }
        public string tipoUnidade { get; set; }
        public string formaAtuacao { get; set; }

    }
}
