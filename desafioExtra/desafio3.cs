//parte 1: modelar uma classe Conta (nova)
class Titular
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Endereco {get; set;}
}

class Conta
{
    public Titular Titular {get; set;}
    public int Agencia {get; set;}
    public int NumeroDaConta {get; set;}
    public double Saldo {get; set;}
    public double Limite {get; set;}

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}

//parte 2: instanciar um objeto do tipo conta
Titular t = new();
Conta c = new();

t.Nome = "George Harrison";
t.Cpf = "000.000.000-00";
t.Endereco = "Rua dos Besouros - Liverpool";

c.Titular = t;
c.Agencia = 1;
c.NumeroDaConta = 2234;
c.Saldo = 10000000.0;
c.Limite = 100000.0;

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular.Nome}");
Console.WriteLine($"CPF: {c.Titular.Cpf}");
Console.WriteLine($"Endereco: {c.Titular.Endereco}");

//parte 3: desenvolver uma nova classe
class Produto
{
    private double preco;
    private int estoque;
    public string Nome {get; set;}
    public string Marca {get; set;}
    public double Preco {
        get => preco; 
        set
        {
            if(value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    
    public int Estoque {
        get => estoque; 
        set 
        {
            if(value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string Descricao => $"{this.Nome} {this.Marca} - {this.Preco} - Quantidade: {this.Estoque}";

}


class EstoqueDeProdutos
{
    private List<Produto> Produtos {get; set;} = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos()
    {
        if(Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach(var produto in Produtos){
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}


//parte 4: modelar o sistema de uma escola
class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
}

class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
}

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();

//parte 5: modelar o sistema de um restaurante
class ProdutoRestaurante
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

class Pedido
{
    public ProdutoRestaurante Produto { get; set; }
    public int Quantidade { get; set; }
}

class Cardapio
{
    public List<ProdutoRestaurante> Itens { get; set; } = new List<ProdutoRestaurante>();
}

class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new List<Mesa>();
    public Cardapio Cardapio { get; set; } = new Cardapio();
}