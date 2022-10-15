namespace CalculadoraBET6
{
    public static class Calculadora
    {
        public static double Somar(double pNum, double sNum)
        {
            return (pNum + sNum);
        }


        public static string CalcularImc(double kg, double altura)
        {
            double resultado = kg / (altura * altura);

            if (resultado < 18.5)
            {
                return "Abaixo do peso";
            }
            if (resultado < 24.9)
            {
                return "Peso Normal";
            }
            if (resultado < 29.9)
            {
                return "Sobre peso";
            }
            if (resultado < 34.9)
            {
                return "Obesidade grau 1";
            }
            if (resultado < 39.9)
            {
                return "Obesidade grau 2";
            }
            else
            {
                return "Obesidade grau 3";
            }
        }


    //Para classes comuns:
    //Calculadora calc = new Calculadora;
    //calc.Somar();


    //Para classes estaticas (static)
    //Calculadora.Somar();
    
    }
}