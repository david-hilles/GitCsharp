using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 5];
            //Indicador dos registro realizados em nosso sitema
            int IndiceBaseDeDados = 0;
            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de noem e idade.");
            //Criamos a variavel fora para não ser criada novament
            var escolhaInicial = ApresentaMenuInicial();
            //Loop infinito ate que de uma treta
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                        //1- Insere as informações
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                        //2- Remove informações da nossa lista
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                        //Lista as informações da lista
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                        //Menu que mostra apenas registros desativados do sistema
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                        //Sai do nosso sistema
                    case "5": {
                            //Return dentro do nosso caso de escolha ele sai do nosso metodo principal ou
                            //metodo que estamos dentro do contexto
                            return;
                        }
                }
                //Alimento a escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }
            
        }
        /// <summary>
        /// Apresenta as informaçoes do menu inicial
        /// </summary>
        ///  </summary> Retorna o menu escolhido.
        public static string ApresentaMenuInicial()
        {
            //ENTROU no menu inicial inicializa a limpeza da TELA
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Listar as informações desativadas.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada :");
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">base de dados como ref para alterar para todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como red para alterar para todos os metodos</param>

        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("------------INSERINDO VALORES NA LISTA--------------");

            Console.WriteLine("Informe um nome :");
            //Pegamos a informação digitada pelo usuario, aqui neste elemento esperamos o nome da pessoa.
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            //Aqui pegamos a idade da pessoa digitada pelo usuario do sistema.
            var idade = Console.ReadLine();
            //Aumenta o tamanho da nossa lista quando chegou no limite.
            AumentarTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)

            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira unica nosso registro "(" e ")" garante que ele incremente primeiro 
                //antes de fazer a conversão para string
                baseDeDados[i, 0] = (indiceBase++).ToString();
                //Carregamos na segunda coluna o valor do nome
                baseDeDados[i, 1] = nome;
                //carregamos na terceira coluna o valor da idade
                baseDeDados[i, 2] = idade;
                //Carrega a coluna que identifica se o registro está ativo
                baseDeDados[i, 3] = "true";
                //Identificamos agora a data e hora de criação dos registros dentro do sistema
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //Finalizamos aqui para apenas inserir um registro por vez...
                break;
            }
            //Informamos para o usuario que finalizou o registro e agora o meso irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu ininical,basta apertar qualquer tecla.");
            Console.ReadKey();

        }
        public static void MostrarInformacoes(string[,] baseDeDados,string mostrarRegistroNAtivos = "false")
        {
            //Informamos em que tela o mesmo esta
            Console.WriteLine("Apresentação das informaçoes dentro da base de dados.");
            //Comparação que identifica visualmente quais registros estamos mostrando
            if (mostrarRegistroNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");
            //Laço simples aonde o mesmo mostra de maneira formatada as informações.
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //aqui deixamos de mostrar as informaçoes que foram desabilitadas dentro do sistema.
                if(baseDeDados[i, 3] != mostrarRegistroNAtivos)
                Console.WriteLine($"ID{baseDeDados[i, 0]}" +
                    $"- Nome:{baseDeDados[i, 1]}" +
                    $"-Idade:{baseDeDados[i, 2]}" +
                $"-Data alteração:{baseDeDados[i, 4]}");
            }

            //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas em
            //nosso metodo.
            Console.WriteLine("Resultados aprensentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();


        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id denro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele ira remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i, 3] != "false")
                Console.WriteLine($"ID:{baseDeDados[i, 0] }" +
                    $"- Nome:{baseDeDados[i, 1]} " +
                    $"-Idade:{baseDeDados[i, 2]}");
            }

            Console.WriteLine("Informe o id registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {   //agora trocamos este valor para um identificador string "false"
                    baseDeDados[i, 3] = "false";
                    //Aqui indicamos a data que foi alterado esse registro.
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    
                }

            }
            //Finalizamos as operações desta tela
            Console.WriteLine("Operação finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();


        }

        public static void AumentarTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)


            {

                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;

            }

            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 1] = listaCopia[i, 1];

                    baseDeDados[i, 2] = listaCopia[i, 2];

                    baseDeDados[i, 3] = listaCopia[i, 3];

                    baseDeDados[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("o tamanho da lista foi att");

            }


        }
    }
}

