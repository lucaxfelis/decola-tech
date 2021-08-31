using System;

namespace AppCadastroSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {   
            Console.WriteLine();
            Console.WriteLine("# # # Aplicativo de Gerenciamento de Séries # # #");

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "L":
                        ListarSeries();
                        break;
                    case "I":
                        InserirSerie();
                        break;
                    case "U":
                        AtualizarSerie();
                        break;
                    case "D":
                        ExcluirSerie();
                        break;
                    case "V":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("\nObrigado e volte sempre! Até logo...");
        }

        private static void ListarSeries()
        {
            Console.WriteLine("\nListar séries:\n");
            var listaSeries = repositorio.Lista();

            if (listaSeries.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach(var serie in listaSeries)
            {
                if (!serie.retornaExclusao())
                    Console.WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()}");
                else
                    Console.WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()} (Excluído)");
            }
            return;
        }

        private static void InserirSerie()
        {
            Console.WriteLine("\nInserir nova série\n");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("\nDigite o gênero entre as opções acima:\n> ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série:\n> ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento da série:\n> ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série:\n> ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
            return;
        }

        public static void AtualizarSerie()
        {
            Console.WriteLine("\nAtualizar entrada existente");
            Console.Write("\nDigite o id da série:\n> ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("\nDigite o gênero entre as opções acima:\n> ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série:\n> ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento da série:\n> ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série:\n> ");
            string entradaDescricao = Console.ReadLine();

            Serie serieAtualizada = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Atualiza(indiceSerie, serieAtualizada);
        }

        public static void ExcluirSerie()
        {
            Console.WriteLine("\nExcluir série da base");
            Console.Write("\nDigite o id da serie:\n>");
            int indiceSerie = int.Parse(Console.ReadLine());
            string tituloSerie = repositorio.RetornaPorId(indiceSerie).retornaTitulo();
            Console.Write($"\nVocê deseja excluir {tituloSerie} (s/N):\n> ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine($"{tituloSerie} foi excluída!");
                repositorio.Exclui(indiceSerie);
            }
            else
            {
                Console.WriteLine($"{tituloSerie} não foi excluída!");
            }
            return;
        }

        public static void VisualizarSerie()
        {
            Console.Write("\nDigite o id da serie:\n>");
            int indiceSerie = int.Parse(Console.ReadLine());
            Serie serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine("\n" + serie);
        }

        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine("\nInforme a opção desejada:\n");
            Console.WriteLine("L - Listar séries");
            Console.WriteLine("I - Inserir nova série");
            Console.WriteLine("U - Atualizar série");
            Console.WriteLine("D - Excluir série");
            Console.WriteLine("V - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            Console.Write("> ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            string opcoesValidas = "LIUDVCX";

            while(!opcoesValidas.Contains(opcaoUsuario))
            {
                Console.Write("\nOpção inválida. Por favor, tente novamente!\n> ");
                opcaoUsuario = Console.ReadLine().ToUpper();
            }

            return opcaoUsuario;
        }
    }
}
