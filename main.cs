using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá! este programa te ajuda a decidir a escolher qual combustível é mais benefíco para o seu bolso na hora de abastecer. Vamos começar ? 1 - Sim, 2 - Não");
        int inicio = 0;
        inicio = int.Parse(Console.ReadLine());

        while (inicio != 2)
        {

            double valorDoAlcool, valorDaGasolina;
            Console.WriteLine("Digite o valor do alcool: ");
            valorDoAlcool = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da gasolina: ");
            valorDaGasolina = double.Parse(Console.ReadLine());

            double vantajoso = (valorDoAlcool / valorDaGasolina);

            if (vantajoso > 07.00)
            {
                Console.WriteLine("Abastecer com Gasolina é mais vantajoso");
            }
            else if (vantajoso < 07.00)
            {
                Console.WriteLine("Abastecer com alcool é mais vantajoso");
            }
            else if (vantajoso == 07.00)
            {
                Console.WriteLine("Os dois combustíveis entregam o mesmo custo benefício");
            }
            Console.WriteLine("Gostaria de fazer um novo cálculo ? 1 - Sim, 2 - Não");
            inicio = int.Parse(Console.ReadLine());
        }
      Console.WriteLine("Obrigado por usar nossa calculadora, até a próxima <3");
  }
}