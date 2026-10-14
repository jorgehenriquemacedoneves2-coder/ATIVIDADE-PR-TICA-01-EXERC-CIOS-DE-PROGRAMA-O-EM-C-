using System;

class Program
{
    static void Main()
    {
        // MENU PRINCIPAL

        Console.WriteLine("=================================");
        Console.WriteLine("       LISTA DE EXERCÍCIOS");
        Console.WriteLine("=================================");
        Console.WriteLine("1 - Cadastro de Aluno");
        Console.WriteLine("2 - Cadastro de Produto");
        Console.WriteLine("3 - Cadastro de Livro");
        Console.WriteLine("4 - Cadastro de Filme");
        Console.WriteLine("5 - Cadastro de Funcionário");
        Console.WriteLine("6 - Cadastro de Veículo");
        Console.WriteLine("7 - Cadastro de Jogo");
        Console.WriteLine("8 - Cadastro de Evento");
        Console.WriteLine("9 - Perfil de Usuário");
        Console.WriteLine("10 - Cadastro de Empresa");
        Console.WriteLine("=================================");

        Console.Write("Escolha um exercício: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        switch (opcao)
        {
            case 1:
                // EXERCÍCIO 01 - CADASTRO DE ALUNO

                Console.WriteLine("=================================");
                Console.WriteLine("       CADASTRO DE ALUNO");
                Console.WriteLine("=================================");

                Console.Write("Nome: ");
                string nomeAluno = Console.ReadLine();

                Console.Write("Idade: ");
                int idadeAluno = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cidade: ");
                string cidadeAluno = Console.ReadLine();

                Console.Write("Altura: ");
                double alturaAluno = Convert.ToDouble(Console.ReadLine());

                Console.Write("Está matriculado? (True/False): ");
                bool matriculado = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("       DADOS DO ALUNO");
                Console.WriteLine("=================================");

                Console.WriteLine("Nome: " + nomeAluno);
                Console.WriteLine("Idade: " + idadeAluno + " anos");
                Console.WriteLine("Cidade: " + cidadeAluno);
                Console.WriteLine("Altura: " + alturaAluno + " metros");
                Console.WriteLine("Matriculado: " + matriculado);

                break;

            case 2:
                // EXERCÍCIO 02 - CADASTRO DE PRODUTO

                Console.WriteLine("=================================");
                Console.WriteLine("      CADASTRO DE PRODUTO");
                Console.WriteLine("=================================");

                Console.Write("Nome do produto: ");
                string produto = Console.ReadLine();

                Console.Write("Código: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Categoria: ");
                string categoria = Console.ReadLine();

                Console.Write("Preço: ");
                double precoProduto = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade em estoque: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Disponível? (True/False): ");
                bool disponivelProduto = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("       DADOS DO PRODUTO");
                Console.WriteLine("=================================");

                Console.WriteLine("Produto: " + produto);
                Console.WriteLine("Código: " + codigo);
                Console.WriteLine("Categoria: " + categoria);
                Console.WriteLine("Preço: R$ " + precoProduto);
                Console.WriteLine("Quantidade: " + quantidade);
                Console.WriteLine("Disponível: " + disponivelProduto);

                break;

            case 3:
                // EXERCÍCIO 03 - CADASTRO DE LIVRO

                Console.WriteLine("=================================");
                Console.WriteLine("        CADASTRO DE LIVRO");
                Console.WriteLine("=================================");

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("Ano de publicação: ");
                int anoLivro = Convert.ToInt32(Console.ReadLine());

                Console.Write("Número de páginas: ");
                int paginas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Preço: ");
                double precoLivro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Disponível? (True/False): ");
                bool disponivelLivro = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("        DADOS DO LIVRO");
                Console.WriteLine("=================================");

                Console.WriteLine("Título: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Ano: " + anoLivro);
                Console.WriteLine("Páginas: " + paginas);
                Console.WriteLine("Preço: R$ " + precoLivro);
                Console.WriteLine("Disponível: " + disponivelLivro);

                break;

            case 4:
                // EXERCÍCIO 04 - CADASTRO DE FILME

                Console.WriteLine("=================================");
                Console.WriteLine("       CADASTRO DE FILME");
                Console.WriteLine("=================================");

                Console.Write("Nome do filme: ");
                string filme = Console.ReadLine();

                Console.Write("Nome do diretor: ");
                string diretor = Console.ReadLine();

                Console.Write("Ano de lançamento: ");
                int anoFilme = Convert.ToInt32(Console.ReadLine());

                Console.Write("Duração em minutos: ");
                int duracao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nota do filme: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                Console.Write("Já foi assistido? (True/False): ");
                bool assistido = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("        DADOS DO FILME");
                Console.WriteLine("=================================");

                Console.WriteLine("Filme: " + filme);
                Console.WriteLine("Diretor: " + diretor);
                Console.WriteLine("Ano: " + anoFilme);
                Console.WriteLine("Duração: " + duracao + " minutos");
                Console.WriteLine("Nota: " + nota);
                Console.WriteLine("Assistido: " + assistido);

                break;

            case 5:
                // EXERCÍCIO 05 - CADASTRO DE FUNCIONÁRIO

                Console.WriteLine("=================================");
                Console.WriteLine("    CADASTRO DE FUNCIONÁRIO");
                Console.WriteLine("=================================");

                Console.Write("Nome: ");
                string nomeFuncionario = Console.ReadLine();

                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();

                Console.Write("Idade: ");
                int idadeFuncionario = Convert.ToInt32(Console.ReadLine());

                Console.Write("Salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Cidade: ");
                string cidadeFuncionario = Console.ReadLine();

                Console.Write("Está ativo? (True/False): ");
                bool ativo = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("      FICHA DO FUNCIONÁRIO");
                Console.WriteLine("=================================");

                Console.WriteLine("Nome: " + nomeFuncionario);
                Console.WriteLine("Cargo: " + cargo);
                Console.WriteLine("Idade: " + idadeFuncionario + " anos");
                Console.WriteLine("Salário: R$ " + salario);
                Console.WriteLine("Cidade: " + cidadeFuncionario);
                Console.WriteLine("Ativo: " + ativo);

                break;

            case 6:
                // EXERCÍCIO 06 - CADASTRO DE VEÍCULO

                Console.WriteLine("=================================");
                Console.WriteLine("       CADASTRO DE VEÍCULO");
                Console.WriteLine("=================================");

                Console.Write("Marca: ");
                string marca = Console.ReadLine();

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Ano: ");
                int anoVeiculo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cor: ");
                string cor = Console.ReadLine();

                Console.Write("Preço: ");
                double precoVeiculo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Disponível para venda? (True/False): ");
                bool disponivelVeiculo = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("       DADOS DO VEÍCULO");
                Console.WriteLine("=================================");

                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Ano: " + anoVeiculo);
                Console.WriteLine("Cor: " + cor);
                Console.WriteLine("Preço: R$ " + precoVeiculo);
                Console.WriteLine("Disponível: " + disponivelVeiculo);

                break;

            case 7:
                // EXERCÍCIO 07 - CADASTRO DE JOGO

                Console.WriteLine("=================================");
                Console.WriteLine("         CADASTRO DE JOGO");
                Console.WriteLine("=================================");

                Console.Write("Nome do jogo: ");
                string nomeJogo = Console.ReadLine();

                Console.Write("Plataforma: ");
                string plataforma = Console.ReadLine();

                Console.Write("Ano de lançamento: ");
                int anoJogo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Preço: ");
                double precoJogo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de jogadores: ");
                int jogadores = Convert.ToInt32(Console.ReadLine());

                Console.Write("Está instalado? (True/False): ");
                bool instalado = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("         DADOS DO JOGO");
                Console.WriteLine("=================================");

                Console.WriteLine("Nome: " + nomeJogo);
                Console.WriteLine("Plataforma: " + plataforma);
                Console.WriteLine("Ano: " + anoJogo);
                Console.WriteLine("Preço: R$ " + precoJogo);
                Console.WriteLine("Jogadores: " + jogadores);
                Console.WriteLine("Instalado: " + instalado);

                break;

            case 8:
                // EXERCÍCIO 08 - CADASTRO DE EVENTO

                Console.WriteLine("=================================");
                Console.WriteLine("       CADASTRO DE EVENTO");
                Console.WriteLine("=================================");

                Console.Write("Nome do evento: ");
                string nomeEvento = Console.ReadLine();

                Console.Write("Local: ");
                string local = Console.ReadLine();

                Console.Write("Data: ");
                string data = Console.ReadLine();

                Console.Write("Quantidade de participantes: ");
                int participantes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Valor do ingresso: ");
                double valorIngresso = Convert.ToDouble(Console.ReadLine());

                Console.Write("O evento é gratuito? (True/False): ");
                bool gratuito = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("        DADOS DO EVENTO");
                Console.WriteLine("=================================");

                Console.WriteLine("Nome: " + nomeEvento);
                Console.WriteLine("Local: " + local);
                Console.WriteLine("Data: " + data);
                Console.WriteLine("Participantes: " + participantes);
                Console.WriteLine("Valor do ingresso: R$ " + valorIngresso);
                Console.WriteLine("Gratuito: " + gratuito);

                break;

            case 9:
                // EXERCÍCIO 09 - PERFIL DE USUÁRIO

                Console.WriteLine("=================================");
                Console.WriteLine("        PERFIL DO USUÁRIO");
                Console.WriteLine("=================================");

                Console.Write("Nome: ");
                string nomeUsuario = Console.ReadLine();

                Console.Write("Nome de usuário: ");
                string usuario = Console.ReadLine();

                Console.Write("Idade: ");
                int idadeUsuario = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cidade: ");
                string cidadeUsuario = Console.ReadLine();

                Console.Write("Altura: ");
                double alturaUsuario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Perfil está ativo? (True/False): ");
                bool perfilAtivo = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("       DADOS DO PERFIL");
                Console.WriteLine("=================================");

                Console.WriteLine("Nome: " + nomeUsuario);
                Console.WriteLine("Usuário: " + usuario);
                Console.WriteLine("Idade: " + idadeUsuario + " anos");
                Console.WriteLine("Cidade: " + cidadeUsuario);
                Console.WriteLine("Altura: " + alturaUsuario + " metros");
                Console.WriteLine("Perfil ativo: " + perfilAtivo);

                break;

            case 10:
                // EXERCÍCIO 10 - CADASTRO DE EMPRESA

                Console.WriteLine("=================================");
                Console.WriteLine("       CADASTRO DE EMPRESA");
                Console.WriteLine("=================================");

                Console.Write("Nome da empresa: ");
                string empresa = Console.ReadLine();

                Console.Write("CNPJ: ");
                string cnpj = Console.ReadLine();

                Console.Write("Cidade: ");
                string cidadeEmpresa = Console.ReadLine();

                Console.Write("Nome do responsável: ");
                string responsavel = Console.ReadLine();

                Console.Write("Número de funcionários: ");
                int funcionarios = Convert.ToInt32(Console.ReadLine());

                Console.Write("Faturamento mensal: ");
                double faturamento = Convert.ToDouble(Console.ReadLine());

                Console.Write("A empresa está ativa? (True/False): ");
                bool empresaAtiva = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("       DADOS DA EMPRESA");
                Console.WriteLine("=================================");

                Console.WriteLine("Empresa: " + empresa);
                Console.WriteLine("CNPJ: " + cnpj);
                Console.WriteLine("Cidade: " + cidadeEmpresa);
                Console.WriteLine("Responsável: " + responsavel);
                Console.WriteLine("Funcionários: " + funcionarios);
                Console.WriteLine("Faturamento mensal: R$ " + faturamento);
                Console.WriteLine("Empresa ativa: " + empresaAtiva);

                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.WriteLine("=================================");

        Console.ReadKey();
    }
}
