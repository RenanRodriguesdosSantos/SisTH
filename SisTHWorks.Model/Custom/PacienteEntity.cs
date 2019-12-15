using System;

namespace SisTHWorks.Model
{
    public partial class PacienteEntity
    {
        private System.String bairro;
        private System.String cidade;
        private System.String naturalidade;
        private System.String tipoLogradouro;
        private System.String etnia;
        private System.String profissao;

        public String Bairro { get => bairro; set => bairro = value; }
        public String Cidade { get => cidade; set => cidade = value; }
        public String Naturalidade { get => naturalidade; set => naturalidade = value; }
        public String TipoLogradouro { get => tipoLogradouro; set => tipoLogradouro = value; }
        public String Etnia { get => etnia; set => etnia = value; }
        public String Profissao { get => profissao; set => profissao = value; }
    }
}
