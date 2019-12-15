using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class PadraoEntity
    {
        private Int32 id;
        private String nome;

        public Int32 Id { get => id; set => id = value; }
        public String Nome { get => nome; set => nome = value; }

        public PadraoEntity(){}
        public PadraoEntity(String Nome)
        {
            this.nome = Nome;
        }
        public PadraoEntity(Int32 Id, String Nome)
        {
            this.id = Id;
            this.nome = Nome;
        }
    }
}
