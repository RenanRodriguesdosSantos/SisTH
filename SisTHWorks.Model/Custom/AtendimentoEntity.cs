using System;
namespace SisTHWorks.Model
{
    public partial class AtendimentoEntity
    {
        private String paciente;
        private String nomeMae;
        private String cpf;
        private DateTime? nascimento;
        private String cor;
        private String enfermeiro;

        public string Paciente { get => paciente; set => paciente = value; }
        public string NomeMae { get => nomeMae; set => nomeMae = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime? Nascimento { get => nascimento; set => nascimento = value; }
        public String Cor { get => cor; set => cor = value; }
        public String Enfermeiro { get => enfermeiro; set => enfermeiro = value; }
    }
}
