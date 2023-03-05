internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2, calculo;
        int opcao = 0;
        void Menu()
        {
            Console.Clear();
            Console.WriteLine("1-Somar");
            Console.WriteLine("2-Subtrair");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Informe o primeiro numero: ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        num2 = double.Parse(Console.ReadLine());
        while (opcao != 5)
        {
            Menu();

            switch (opcao)
            {
                default:
                    Console.WriteLine("Opção invalida.");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("Soma: " + Soma());
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Subtração: " + Subtracao());
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Multiplicacção: " + Multiplicaçao());
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Divisão: " + Divisao());
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Até logo.");
                    Console.ReadLine();
                    break;
            }
        }
        double Soma()
        {
            calculo = num1 + num2;
            return calculo;
        }
        double Subtracao()
        {
            calculo = num1 - num2;
            return calculo;
        }
        double Multiplicaçao()
        {
            calculo = num1 * num2;
            return calculo;
        }
        double Divisao()
        {
            calculo = num1 / num2;
            return calculo;
        }
    }
}