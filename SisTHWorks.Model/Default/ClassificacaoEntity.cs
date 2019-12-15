using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Model
{
    public partial class ClassificacaoEntity
    {
        private Int32 id;
        private Int32 fluxograma;
        private Int32 discriminador;
        private Int32 cor;
        
        public Int32 Id { get => id; set => id = value; }
        public Int32 Fluxograma { get => fluxograma; set => fluxograma = value; }
        public Int32 Discriminador { get => discriminador; set => discriminador = value; }
        public Int32 Cor { get => cor; set => cor = value; }

        public ClassificacaoEntity(){}
        public ClassificacaoEntity(Int32 Fluxograma, Int32 Discriminador, Int32 Cor)
        {
            this.fluxograma = Fluxograma;
            this.discriminador = Discriminador;
            this.cor = Cor;
        }
        public ClassificacaoEntity(Int32 Id, Int32 Fluxograma, Int32 Discriminador, Int32 Cor)
        {
            this.id = Id;
            this.fluxograma = Fluxograma;
            this.discriminador = Discriminador;
            this.cor = Cor;
        }
        public String GetCor()
        {
            switch (this.cor)
            {
                case 1: return "Vermelho";
                case 2: return "Laranja";
                case 3: return "Amarelo";
                case 4: return "Verde";
                case 5: return "Azul";
            }
            return "Não Definido";
        }
    }
}
