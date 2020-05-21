//Ramo - Teste Técnico - Daniel Paiva
using System;

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
            Apresentacao(); //Chamando o método apresentação
        }

        static void Apresentacao() //Método que chama a tela inicial e a função Lista de Classificação e Classificação de Cores
        {
            int opcao;

            Console.WriteLine("\n\tRamo - Seleção da Função");
            Console.WriteLine("\n\tInforme a opção desejada: \n\t1-Lista de Classificação | 2-Classificação por Cores | 3-Sair");

            opcao = int.Parse(Console.ReadLine()); //TypeCast para conversão de dados coletados

            //Condição para escolher entre chamar a lista de classificação ou classificação por cores
            switch (opcao)
            {
                case 1:
                    Listar();
                    break;
                case 2:
                    Passageiro pessoa = new Passageiro(); //Criação do Objeto - Instanciado
                    Classificar(ref pessoa);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar nosso programa.");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
        static void Listar()
        {
            string voltar;

            Console.Clear(); //Limpar a tela

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

            Console.WriteLine("\nGostaria de voltar pra tela de seleção?\n1-Voltar pra tela de seleção");
            voltar = Console.ReadLine();

            //Condição para voltar a tela de Seleção
            if (voltar == "1" | voltar == "s" | voltar == "sim")
            {
                Console.Clear();
                Apresentacao();
            }
        }

        static void Classificar(ref Passageiro pessoa)
        {
            string voltar;

            //Repetição caso queira realizar uma nova leitura da Classificação por Cores
            do
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

                //Condição para pegar a classe e cor do assento do passageiro acima ou igual 65 anos
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

                //Imprimindo a resposta para o usuário
                Mensagem(pessoa);

                Console.WriteLine("\nInforme a opção:\n1-Repetir processo de leitura | 2-Voltar a tela Seleção da Função");
                voltar = Console.ReadLine();

            } while (voltar == "1" | voltar == "sim" | voltar == "s");

            //Condição para ir a tela Seleção de Função
            if (voltar == "2")
            {
                Console.Clear();
                Apresentacao();
            }
        }
        static void Mensagem(Passageiro pessoa)
        {
            Console.WriteLine("\nO passageiro {0}, " +
            "apresentando idade de {1} anos, \ndeverá procurar a classe {2} e " +
             "se assentar em um dos assentos de cor {3}.", pessoa.nome, pessoa.idade, pessoa.classe, pessoa.cor);
        }
    }
}
