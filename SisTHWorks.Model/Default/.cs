using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class ProfissaoEntity
    {
        private Int32 id;
        private String nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public ProfissaoEntity() { }
        public ProfissaoEntity(String Nome, Int32 Id = 0)
        {
            this.nome = Nome;
            this.id = Id;
        }

    }
}
