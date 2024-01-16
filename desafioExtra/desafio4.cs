//parte 1: criar um construtor para a classe titular
class Titular
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Endereco {get; set;}

    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }


//parte 2: criar um construtor para a classe 
class Conta
{
    public Titular Titular {get; set;}
    public int Agencia {get; set;}
    public int NumeroDaConta {get; set;}
    public double Saldo {get;}
    public double Limite {get; set;}

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Conta(Titular titular, Agencia agencia, NumeroDaConta numeroDaConta, Limite limite)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.NumeroDaConta = numeroDaConta;
        this.Limite = limite;
        this.Saldo = 0
    }
}

//parte 3: instanciar uma conta
Titular titular = new Titular("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");
Conta c = new Conta(titular, 1, 2234, 100000);

Console.WriteLine(c.Informacoes);

//parte 4: desenvolver uma classe que represente um catalogo de jogos
class Jogo
{
    public string Nome { get; set; }
    public string Genero { get; set; }
    public int AnoLancamento { get; set; }

    public Jogo(string nome, string genero, int anoLancamento)
    {
        Nome = nome;
        Genero = genero;
        AnoLancamento = anoLancamento;
    }
}

class CatalogoJogos
{
    private List<Jogo> Jogos { get; set; }

    // Propriedade que retorna se o catálogo está vazio
    public bool CatalogoVazio => Jogos.Count == 0;

    // Construtor para inicializar o catálogo de jogos vazio
    public CatalogoJogos()
    {
        Jogos = new List<Jogo>();
    }

    // Método para adicionar um jogo ao catálogo
    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }

    // Método para listar todos os jogos no catálogo
    public void ListarJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio.");
        }
        else
        {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }
}
