using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoRamo
{
    public class Passageiro //Criação da classe passageiro com seus atributos
    {
        public string nome = "", classe = "", cor = "";
        public int idade = 0;
        public double valorBilhete = 0;
    }
    public class Program //Criação da classe do programa
    {
        static void Main(string[] args) //Método principal que chama a tela de apresentação
        {
            string voltar;

            //Repetição para saber quando o usuário quer refazer o processo do programa
            do
            {
                apresentacao(); //Chamando o método apresentação

                Console.WriteLine("\nGostaria de voltar a tela Seleção de Função? 1-sim |2-não");
                voltar = Console.ReadLine();

                Console.Clear(); //Método para limpar o processo anterior
            }
            while (voltar == "1" | voltar == "s" | voltar == "sim");
        }

        static void apresentacao() //Método de "Boas - Vindas"
        {
            int opcao;

            Console.WriteLine("\n\tRamo - Seleção da Função");
            Console.Write("\n\tInforme a opção desejada: \n\t1-Lista de Classificação | 2-Classificação por Cores ");

            opcao = int.Parse(Console.ReadLine()); //TypeCast para conversão de dados coletados

            switch (opcao)
            {
                case 1:
                    Listar();
                    break;
                case 2:
                    Passageiro pessoa = new Passageiro(); //Criação do Objeto - Instanciado
                    Cadastrar(ref pessoa);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
        static void Listar()
        {
            Console.Clear();
            Console.WriteLine("\n\tLista de Classificação: ");
            Console.WriteLine("\nIdade do Passageiro | Valor do Bilhete        | Classe do Passageiro | Cor do Assento\n");
            Console.WriteLine("De  0 a 10 anos     | De R$ 1,00 a R$ 49,99   | Econômica            | Azul");
            Console.WriteLine("De 11 a 64 anos     | De R$ 1,00 a R$ 49,99   | Econômica            | Amarelo");
            Console.WriteLine("Acima de 65 anos    | De R$ 1,00 a R$ 49,99   | Econômica            | Verde");
            Console.WriteLine("De  0 a 10 anos     | De R$ 50,00 a R$ 99,99  | Executiva            | Azul");
            Console.WriteLine("De 11 a 64 anos     | De R$ 50,00 a R$ 99,99  | Executiva            | Amarelo");
            Console.WriteLine("Acima de 65 anos    | De R$ 50,00 a R$ 99,99  | Executiva            | Verde");
            Console.WriteLine("De  0 a 10 anos     | De R$ 100,00 acima      | Luxo                 | Azul");
            Console.WriteLine("De 11 a 64 anos     | De R$ 100,00 acima      | Luxo                 | Amarelo");
            Console.WriteLine("Acima de 65 anos    | De R$ 100,00 acima      | Luxo                 | Verde");
        }

        static void Cadastrar(ref Passageiro pessoa)
        {
            Console.Clear();
            Console.WriteLine("\n\tClassificação por Cores: ");

            Console.WriteLine("\nInforme o nome do passageiro: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do passageiro: ");
            pessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do bilhete: ");
            pessoa.valorBilhete = double.Parse(Console.ReadLine());

            //Condição para pegar a classe e cor do assento do passageiro até 10 anos
            if (pessoa.idade <= 10)
            {
                pessoa.cor = "Azul"; //Setando a cor do assento do passageiro
                //Condição para pegar a classe do passageiro
                if (pessoa.valorBilhete <= 49.99)
                {
                    pessoa.classe = "Econômica";
                }
                else if (pessoa.valorBilhete <= 99.99)
                {
                    pessoa.classe = "Executiva";
                }
                else
                {
                    pessoa.classe = "Luxo";
                }
            }
            //Condição para pegar a classe e cor do assento do passageiro até 64 anos
            else if (pessoa.idade <= 64)
            {
                pessoa.cor = "Amarelo";
                //Condição para pegar a classe do passageiro
                if (pessoa.valorBilhete <= 49.99)
                {
                    pessoa.classe = "Econômica";
                }
                else if (pessoa.valorBilhete <= 99.99)
                {
                    pessoa.classe = "Executiva";
                }
                else
                {
                    pessoa.classe = "Luxo";
                }
            }
            //Condição para pegar a classe e cor do assento do passageiro acima ou igual de 65 anos
            else
            {
                pessoa.cor = "Verde";
                //Condição para pegar a classe do passageiro
                if (pessoa.valorBilhete <= 49.99)
                {
                    pessoa.classe = "Econômica";
                }
                else if (pessoa.valorBilhete <= 99.99)
                {
                    pessoa.classe = "Executiva";
                }
                else
                {
                    pessoa.classe = "Luxo";
                }
            }

            Console.WriteLine("\nO passageiro {0}, apresentando idade de {1} anos, \ndeverá procurar a classe {2} e se assentar em um dos assentos de cor {3}.", pessoa.nome, pessoa.idade, pessoa.classe, pessoa.cor);
        }
    }
}
