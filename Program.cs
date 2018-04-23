using System;

namespace ProgramaComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Criando as variáveis no formato double, que pode ser usado com números quebrados para o conforto de quem utilizar o programa.
             */
            double valorMeta, valorVenda, perComissao, valorComissao;
                            
            Console.Clear(); //Limpando a tela do cliente
            Console.WriteLine("Digite o valor da meta"); //Oque aparecerá na tela do cliente
            valorMeta = double.Parse(Console.ReadLine()); //Convertendo o double em String

            Console.WriteLine("Digite o percentual de comissão");
            perComissao = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da venda");
            valorVenda = double.Parse(Console.ReadLine());


                if(valorVenda>=valorMeta)
                    valorComissao = valorVenda*(perComissao/100);
                else
                    valorComissao = 0;

            Console.WriteLine("O valor da comissao é: " +valorComissao);


        }
    }
}
