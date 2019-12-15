using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class AtendimentoEntity
    {
        private Int32 id;
        private Int32 registro;
        private DateTime dataHora;
        private Decimal? saturacao;
        private Decimal? glasgow;
        private Decimal? tax;
        private Decimal? hgt;
        private String pa;
        private Decimal? fc;
        private String descricao;
        private Int32 idClassificacao;
        private Int32 idPaciente;
        private Int32 idEnfermeiro;

        public Int32 Id { get => id; set => id = value; }
        public Int32 Registro { get => registro; set => registro = value; }
        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        public Decimal? Saturacao { get => saturacao; set => saturacao = value; }
        public Decimal? Glasgow { get => glasgow; set => glasgow = value; }
        public Decimal? Tax { get => tax; set => tax = value; }
        public Decimal? Hgt { get => hgt; set => hgt = value; }
        public String Pa { get => pa; set => pa = value; }
        public Decimal? Fc { get => fc; set => fc = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Int32 IdClassificacao { get => idClassificacao; set => idClassificacao = value; }
        public Int32 IdPaciente { get => idPaciente; set => idPaciente = value; }
        public Int32 IdEnfermeiro { get => idEnfermeiro; set => idEnfermeiro = value; }

        public AtendimentoEntity(){}

        public AtendimentoEntity(Int32 Registro, DateTime DataHora, Decimal Saturacao, Decimal Glasgow, Decimal Tax, Decimal Hgt, String Pa, Decimal Fc, string Descricao,Int32 IdClassificacao, Int32 IdPaciente, Int32 IdEnfermeiro)
        {
            this.registro = Registro;
            this.dataHora = DataHora;
            this.saturacao = Saturacao;
            this.glasgow = Glasgow;
            this.tax = Tax;
            this.hgt = Hgt;
            this.pa = Pa;
            this.fc = Fc;
            this.descricao = Descricao;
            this.idClassificacao = IdClassificacao;
            this.idPaciente = IdPaciente;
            this.idEnfermeiro = IdEnfermeiro;
        }
        public AtendimentoEntity(Int32 Id, Int32 Registro, DateTime DataHora, Decimal Saturacao, Decimal Glasgow, Decimal Tax, Decimal Hgt, String Pa, Decimal Fc, string Descricao,Int32 IdClassificacao, Int32 IdPaciente, Int32 IdEnfermeiro)
        {
            this.id = Id;
            this.registro = Registro;
            this.dataHora = DataHora;
            this.saturacao = Saturacao;
            this.glasgow = Glasgow;
            this.tax = Tax;
            this.hgt = Hgt;
            this.pa = Pa;
            this.fc = Fc;
            this.descricao = Descricao;
            this.idClassificacao = IdClassificacao;
            this.idPaciente = IdPaciente;
            this.idEnfermeiro = IdEnfermeiro;
        }
    }
}
