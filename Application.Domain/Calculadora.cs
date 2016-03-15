namespace Application.Domain
{	
    public class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Diminuir(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1/numero2; //Testand......
        }
    }
}
