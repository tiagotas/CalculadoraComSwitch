using System;

namespace CalculadoraComSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool repetir = false;

            do
            {
                Console.WriteLine("Vai repetir forever");

            } while (repetir);*/













            string operacao;
            double n1, n2, resultado = 0;

            bool fazer_outra_operacao = false;
            do
            {
                Console.Clear();

                Console.WriteLine("Calculadora do Console");
                Console.WriteLine("Informe a operação desejada e em seguida dois números");
                Console.WriteLine("Informe a Operação");
                Console.WriteLine("Digite + para Adição");
                Console.WriteLine("Digite - para Subtração");
                Console.WriteLine("Digite * para Multiplicação");
                Console.WriteLine("Digite / para Divisão");


                bool digitacao_valida_operacao = false;
                do
                {
                    operacao = Console.ReadLine();

                    switch (operacao)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            digitacao_valida_operacao = true;
                            break;

                        default:
                            /*digitacao_valida_operacao = false; Desnecessário */
                            Console.WriteLine("Digite uma operação válida. Você digitou {0} ", operacao);
                            break;
                    }
                } while (!digitacao_valida_operacao);


                bool digitacao_valida_n1 = false;
                do
                {
                    Console.WriteLine("Digite o primeiro número: ");

                    digitacao_valida_n1 = Double.TryParse(Console.ReadLine(), out n1);

                    //n1 = Convert.ToDouble(Console.ReadLine());
                    //digitacao_valida_n1 = true;

                } while (!digitacao_valida_n1); // Repete enquanto digitacao_valida_n1 NÃO (!) for válida (true)
                                                // Para o while repetir o booleano dentro do () deve ser true             


                bool digitacao_valida_n2 = false;
                do
                {
                    Console.WriteLine("Digite o segundo número: ");
                    digitacao_valida_n2 = Double.TryParse(Console.ReadLine(), out n2);

                } while (!digitacao_valida_n2);


                switch (operacao)
                {
                    case "+":
                        resultado = n1 + n2;
                        break;

                    case "-":
                        resultado = n1 - n2;
                        break;

                    case "*":
                        resultado = n1 * n2;
                        break;

                    case "/":
                        resultado = n1 / n2;
                        break;

                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }

                Console.WriteLine("n1 = {0} e n2 = {1}", n1, n2);
                Console.WriteLine("O resultado é {0}", resultado);



                Console.WriteLine("Deseja fazer outra operação? S/n");

                /*if (Console.ReadLine().ToUpper() == "S")
                    fazer_outra_operacao = true;
                else
                    fazer_outra_operacao = false;*/

                // Fazendo com Operador Ternário
                fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                

            } while (fazer_outra_operacao);


            Console.WriteLine("Fim do Programa");
            Console.ReadLine();
        }
    }
}
