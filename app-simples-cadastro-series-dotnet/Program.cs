using System;

namespace AppCadastroMidias
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static void Main(string[] args)
        {   
            Console.WriteLine();
            Console.WriteLine("# # # Aplicativo de Gerenciamento de Mídias Visuais # # #");

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "L":
                        string opcaoModuloL = ObterModulo("listar");
                        if (opcaoModuloL == "S")
                            ListarSeries();
                        else
                            ListarFilmes();
                        break;
                    case "I":
                        string opcaoModuloI = ObterModulo("inserir");
                        if (opcaoModuloI == "S")
                            InserirSerie();
                        else
                            InserirFilme();
                        break;
                    case "U":
                        string opcaoModuloU = ObterModulo("atualizar");
                        if (opcaoModuloU == "S")
                            AtualizarSerie();
                        else
                            AtualizarFilme();
                        break;
                    case "D":
                        string opcaoModuloD = ObterModulo("excluir");
                        if (opcaoModuloD == "S")
                            ExcluirSerie();
                        else
                            ExcluirFilme();
                        break;
                    case "V":
                        string opcaoModuloV = ObterModulo("visualizar");
                        if (opcaoModuloV == "S")
                            VisualizarSerie();
                        else
                            VisualizarFilme();
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
            var listaSeries = repositorioSerie.Lista();

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

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Insere(novaSerie);
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
            
            repositorioSerie.Atualiza(indiceSerie, serieAtualizada);
            return;
        }

        public static void ExcluirSerie()
        {
            Console.WriteLine("\nExcluir série da base");
            Console.Write("\nDigite o id da serie:\n>");
            int indiceSerie = int.Parse(Console.ReadLine());
            string tituloSerie = repositorioSerie.RetornaPorId(indiceSerie).retornaTitulo();
            Console.Write($"\nVocê deseja excluir {tituloSerie} (s/N):\n> ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine($"{tituloSerie} foi excluída!");
                repositorioSerie.Exclui(indiceSerie);
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
            Serie serie = repositorioSerie.RetornaPorId(indiceSerie);
            Console.WriteLine("\n" + serie);
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("\nListar filmes:\n");
            var listaFilmes = repositorioFilme.Lista();

            if (listaFilmes.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach(var filme in listaFilmes)
            {
                if (!filme.retornaExclusao())
                    Console.WriteLine($"#ID {filme.retornaId()}: - {filme.retornaTitulo()}");
                else
                    Console.WriteLine($"#ID {filme.retornaId()}: - {filme.retornaTitulo()} (Excluído)");
            }
            return;
        }

        private static void InserirFilme()
        {
            Console.WriteLine("\nInserir novo filme\n");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("\nDigite o gênero entre as opções acima:\n> ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título do filme:\n> ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de lançamento do filme:\n> ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do filme:\n> ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a nota do filme:\n> ");
            double entradaNota = double.Parse(Console.ReadLine());

            Console.Write("Digite a duração do filme (em minutos):\n> ");
            int entradaDuracao = int.Parse(Console.ReadLine());

            Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        nota: entradaNota,
                                        duracao: entradaDuracao);

            repositorioFilme.Insere(novoFilme);
            return;
        }

        public static void AtualizarFilme()
        {
            Console.WriteLine("\nAtualizar entrada existente");
            Console.Write("\nDigite o id do filme:\n> ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("\nDigite o gênero entre as opções acima:\n> ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo título do filme:\n> ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o novo ano de lançamento do filme:\n> ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a nova descrição do filme:\n> ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a nova nota do filme:\n> ");
            double entradaNota = double.Parse(Console.ReadLine());

            Console.Write("Digite a nova duração do filme (em minutos):\n> ");
            int entradaDuracao = int.Parse(Console.ReadLine());

            Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        nota: entradaNota,
                                        duracao: entradaDuracao);

            repositorioFilme.Atualiza(indiceFilme, novoFilme);
            return;
        }

        public static void ExcluirFilme()
        {
            Console.WriteLine("\nExcluir filme da base");
            Console.Write("\nDigite o id do filme:\n>");
            int indiceFilme = int.Parse(Console.ReadLine());
            string tituloFilme = repositorioFilme.RetornaPorId(indiceFilme).retornaTitulo();
            Console.Write($"\nVocê deseja excluir {tituloFilme} (s/N):\n> ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine($"{tituloFilme} foi excluído!");
                repositorioFilme.Exclui(indiceFilme);
            }
            else
            {
                Console.WriteLine($"{tituloFilme} não foi excluído!");
            }
            return;
        }

        public static void VisualizarFilme()
        {
            Console.Write("\nDigite o id do Filme:\n>");
            int indiceFilme = int.Parse(Console.ReadLine());
            Filme filme = repositorioFilme.RetornaPorId(indiceFilme);
            Console.WriteLine("\n" + filme);
        }

        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine("\nInforme a opção desejada:\n");
            Console.WriteLine("L - Listar mídias");
            Console.WriteLine("I - Inserir nova mídia");
            Console.WriteLine("U - Atualizar mídia");
            Console.WriteLine("D - Excluir mídia");
            Console.WriteLine("V - Visualizar mídia");
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

        private static string ObterModulo(string operacao)
        {
            Console.WriteLine($"\nInforme se deseja {operacao} séries ou filmes:\n");
            Console.WriteLine("S - Séries");
            Console.WriteLine("F - Filmes\n");
            Console.Write("> ");

            string opcaoModulo = Console.ReadLine().ToUpper();
            while (opcaoModulo != "S" && opcaoModulo != "F")
            {
                Console.Write("\nOpção inválida. Por favor, tente novamente!\n> ");
                opcaoModulo = Console.ReadLine().ToUpper();
            }
            
            return opcaoModulo;
        }
    }
}
