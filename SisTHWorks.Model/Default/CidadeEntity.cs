using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class CidadeEntity
    {
        //Propriedades
        private System.Int32 id;
        private System.String nome;
        private System.String uf;

        //Propriedades Get/Set
        public Int32 Id { get => id; set => id = value; }
        public String Nome { get => nome; set => nome = value; }
        public String Cidade { get => nome; set => nome = value; }
        public String Uf { get => uf; set => uf = value; }

        //Construtores
        public CidadeEntity() { }
        public CidadeEntity(System.String nome, System.String Uf)
        {
            this.nome = Nome;
            this.uf = Uf;
        }
        public CidadeEntity(System.Int32 Id, System.String nome, System.String Uf)
        {
            this.id = Id;
            this.nome = Nome;
            this.uf = Uf;
        }
    }
}
