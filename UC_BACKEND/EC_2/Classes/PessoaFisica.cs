using CadastroPessoaFST14.Interfaces;

namespace CadastroPessoaFST14.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}