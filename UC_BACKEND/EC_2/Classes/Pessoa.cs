using CadastroPessoaFST14.Interfaces;

namespace CadastroPessoaFST14.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string nome { get; set; }

        public float rendimento { get; set; }

        public Endereco end { get; set; }


        public abstract float CalcularImposto(float rendimento);

    }
}