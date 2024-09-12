namespace Calculadora
{
    internal class Operacoes
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }

        public Operacoes(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public Operacoes()
        {

        }

        public double Somar()
        {
            double resultado = num1 + num2;
            return resultado;
        }

        public double Subtrair()
        {
            double resultado = num1 - num2;
            return resultado;
        }

        public double Multiplicar()
        {
            double resultado = num1 * num2;
            return resultado;
        }

        public double Dividir()
        {
            double resultado = num1 / num2;
            return resultado;
        }

    
    }
}
