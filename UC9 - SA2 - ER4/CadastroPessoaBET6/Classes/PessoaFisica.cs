using CadastroPessoaBET6.Interfaces;

namespace CadastroPessoaBET6.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string? Cpf { get; set; }

        public DateTime dataNasc { get; set; }



        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

            return false;
        }


        public bool ValidarDataNasc(string dataNasc)
        {

            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }

                return false;
            }

            return false;

        }
    }
}