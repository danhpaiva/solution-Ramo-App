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

            Console.ForegroundColor = ConsoleColor.Blue; //Mudar cor da fonte
            Console.WriteLine("\n\tRamo - Seleção da Função");
            Console.ResetColor(); //Voltar ao padrão de cor
            Console.WriteLine("\nInforme a opção desejada: \n[1]Lista de Classificação | [2]Classificação por Cores | [3]Sair");

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
                    Console.WriteLine("\nObrigado por usar nosso programa.");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nOpção Inválida!");
                    break;
            }
        }
        static void Listar()
        {
            string voltar;

            Console.Clear(); //Limpar a tela

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tLista de Classificação: ");
            Console.ResetColor();

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

            Console.WriteLine("\nGostaria de voltar pra tela de seleção?\n[1]Voltar pra tela de seleção");
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
            string repetir;

            //Repetição caso queira realizar uma nova leitura na tela Classificação por Cores
            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tClassificação por Cores: ");
                Console.ResetColor();


                Console.WriteLine("\nInforme o nome do passageiro: ");
                pessoa.nome = Console.ReadLine();

                //Repetição enquanto o usuário digitar uma idade superior a 120 ou inferior a 0
                do
                {
                    Console.WriteLine("\nInforme a idade do passageiro: ");
                    pessoa.idade = int.Parse(Console.ReadLine());
                    if(pessoa.idade > 120 | pessoa.idade < 0)
                    {
                        Console.WriteLine("Informe uma idade entre 0 e 120 anos");
                    }
                } while (pessoa.idade > 120 | pessoa.idade < 0);

                //Repetição enquanto o usuário digitar um valor de bilhete inferior a R$ 1
                do
                {
                    Console.WriteLine("\nInforme o valor do bilhete: ");
                    pessoa.valorBilhete = double.Parse(Console.ReadLine());
                    if(pessoa.valorBilhete < 1)
                    {
                        Console.WriteLine("Não existe bilhete neste valor.");
                    }
                } while (pessoa.valorBilhete < 1);

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

                Console.WriteLine("\nDigite 1 ou 2:\n[1]Repetir processo de leitura | [2]Voltar para a tela Seleção da Função");
                repetir = Console.ReadLine();

            } while (repetir == "1" | repetir == "sim" | repetir == "s");

            //Condição para ir a tela Seleção de Função
            if (repetir == "2")
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
