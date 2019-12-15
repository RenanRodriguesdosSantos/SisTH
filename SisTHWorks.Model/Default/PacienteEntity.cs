using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class PacienteEntity
    {
        //Propriedades
        private System.Int32 id;
        private System.String nome;
        private System.String nomeMae;
        private System.String cpf;
        private System.DateTime? nascimento;
        private System.String logradouro;
        private System.Int32 numero;
        private System.String complemento;
        private System.Int32 idBairro;
        private System.Int32 idCidade;
        private System.Int32 idNaturalidade;
        private System.Int32 idTipoLogradouro;
        private System.Int32 idEtnia;
        private System.Int32 idProfissao;
        

        //Propriedades Get/Set
        public Int32 Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string NomeMae { get => nomeMae; set => nomeMae = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime? Nascimento { get => nascimento; set => nascimento = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public Int32 Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public Int32 IdBairro { get => idBairro; set => idBairro = value; }
        public Int32 IdCidade { get => idCidade; set => idCidade = value; }
        public Int32 IdNaturalidade { get => idNaturalidade; set => idNaturalidade = value; }
        public Int32 IdTipoLogradouro { get => idTipoLogradouro; set => idTipoLogradouro = value; }
        public Int32 IdEtnia { get => idEtnia; set => idEtnia = value; }
        public Int32 IdProfissao { get => idProfissao; set => idProfissao = value; }

        //Construtores
        public PacienteEntity(){}
        public PacienteEntity(String Nome, String NomeMae, String Cpf, DateTime Nascimento, String Logradouro, Int32 Numero, String Complemento, Int32 IdBairro, Int32 IdCidade, Int32 IdNaturalidade, Int32 IdTipoLogradouro, Int32 IdEtnia, Int32 IdProfissao)
        {
            this.nome = Nome;
            this.nomeMae = NomeMae;
            this.cpf = Cpf;
            this.nascimento = Nascimento;
            this.logradouro = Logradouro;
            this.numero = Numero;
            this.complemento = Complemento;
            this.idBairro = IdBairro;
            this.idCidade = IdCidade;
            this.idNaturalidade = IdNaturalidade;
            this.idTipoLogradouro = IdTipoLogradouro;
            this.idEtnia = IdEtnia;
            this.idProfissao = IdProfissao;
        }
        public PacienteEntity(Int32 Id, String Nome, String NomeMae, String Cpf, DateTime Nascimento, String Logradouro, Int32 Numero, String Complemento, Int32 IdBairro, Int32 IdCidade, Int32 IdNaturalidade, Int32 IdTipoLogradouro, Int32 IdEtnia, Int32 IdProfissao)
        {
            this.id = Id;
            this.nome = Nome;
            this.nomeMae = NomeMae;
            this.cpf = Cpf;
            this.nascimento = Nascimento;
            this.logradouro = Logradouro;
            this.numero = Numero;
            this.complemento = Complemento;
            this.idBairro = IdBairro;
            this.idCidade = IdCidade;
            this.idNaturalidade = IdNaturalidade;
            this.idTipoLogradouro = IdTipoLogradouro;
            this.idEtnia = IdEtnia;
            this.idProfissao = IdProfissao;
        }
    }
}
