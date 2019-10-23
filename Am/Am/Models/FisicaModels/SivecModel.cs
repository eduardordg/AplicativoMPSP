using System;
using System.Collections.Generic;
using System.Text;

namespace Am.Models
{
    public class SivecModel
    {
        public override string ToString()
        {
            string somaDados = null;

            somaDados = "----------------------- DADOS SIVEC -------------------------  \n\n\n\n";
            somaDados += "Nome: " + nome + "\n\n";
            somaDados += "Sexo: " + sexo + "\n\n";
            somaDados += "RG: " + rg + "\n\n";
            somaDados += "Tipo do RG: " + tipoRg + "\n\n";
            somaDados += "Data de nascimento: " + dtNascimento + "\n\n";
            somaDados += "Controle Vec: " + controleVec + "\n\n";
            somaDados += "Emissão do RG: " + emissaoRg + "\n\n";
            somaDados += "Estado Civil: " + estadoCivil + "\n\n";
            somaDados += "Naturalizado: " + naturalizado + "\n\n";
            somaDados += "Naturalidade: " + naturalidade + "\n\n";
            somaDados += "Grau Instituição: " + grauInstituicao + "\n\n";
            somaDados += "Nome do Pai: " + nomePai + "\n\n";
            somaDados += "Nome da Mãe: " + nomeMae + "\n\n";
            somaDados += "Cor da pele: " + corPele + "\n\n";
            somaDados += "Profissão: " + profissao + "\n\n";
            somaDados += "Cabelo: " + cabelo + "\n\n";
            somaDados += "Cor dos olhos: " + corOlhos + "\n\n";
            somaDados += "Formula Fundamental: " + formulaFundamental + "\n\n";
            somaDados += "Posto de Identificação: " + postoIdentificacao + "\n\n";
            somaDados += "Residencial: " + residencial + "\n\n";
            somaDados += "Trabalho: " + trabalho + "\n\n";
            somaDados += "Nome Outros: " + nomeOutros + "\n\n";
            somaDados += "Rg Outros: " + rgOutros + "\n\n";
            somaDados += "Data nascimento outros: " + dtNascimentoOutros + "\n\n";
            somaDados += "Nacionalidade outros: " + nacionalidadeOutros + "\n\n";
            somaDados += "Nome do Pai outros: " + nomePaiOutros + "\n\n";
            somaDados += "Nome da Mãe outros: " + nomeMaeOutros + "\n\n";


            return somaDados;
        }

        public SivecModel()
        {
        }

        public string nome { get; set; }
        public string sexo { get; set; }
        public string rg { get; set; }
        public string tipoRg { get; set; }
        public string dtNascimento { get; set; }
        public string controleVec { get; set; }
        public string emissaoRg { get; set; }
        public string estadoCivil { get; set; }

        public string naturalizado { get; set; }
        public string naturalidade { get; set; }
        public string grauInstituicao { get; set; }
        public string nomePai { get; set; }
        public string nomeMae { get; set; }
        public string corPele { get; set; }
        public string profissao { get; set; }
        public string cabelo { get; set; }
        public string corOlhos { get; set; }
        public string formulaFundamental { get; set; }

        public string postoIdentificacao { get; set; }
        public string residencial { get; set; }
        public string trabalho { get; set; }
        public string nomeOutros { get; set; }
        public string rgOutros { get; set; }
        public string dtNascimentoOutros { get; set; }
        public string nacionalidadeOutros { get; set; }
        public string nomePaiOutros { get; set; }
        public string nomeMaeOutros { get; set; }
        

    }
}
