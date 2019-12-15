using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class EnfermeiroEntity
    {
        //Propriedades
        private System.Int32 id;
        private System.String nome;
        private System.Int32 coren;
        private System.String login;
        private System.String senha;

        //Propriedades Get/Set
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Int32 Coren { get => coren; set => coren = value; }
        public String Login { get => login; set => login = value; }
        public String Senha { get => senha; set => senha = value; }

        //Construtores
        public EnfermeiroEntity(){}
        public EnfermeiroEntity(System.String Nome, System.Int32 Coren, System.String Login, String Senha)
        {
            this.id = Id;
            this.nome = Nome;
            this.coren = Coren;
            this.login = Login;
            this.senha = Senha;
        }
        public EnfermeiroEntity(System.Int32 Id, System.String Nome, System.Int32 Coren, System.String Login, String Senha)
        {
            this.id = Id;
            this.nome = Nome;
            this.coren = Coren;
            this.login = Login;
            this.senha = Senha;
        }
    }
}
