//parte 1: reescrever a classe conta
class Conta{
    public string Titular {get; set;}
    public int IdConta {get; set;}
    public float Saldo {get; set;}
    public int Senha {get; set;}
}

//parte 2: reescrever os atributos do carro
class Carro
{
    public string Fabricante {get; set;}
    public string Modelo {get; set;}
    public int Ano {get; set;}
    public int QuantidadePortas{get; set;}
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";
}

//parte 3: reescrever uma propriedade da classe carro
class Carro
{
    private int ano;
    public string Fabricante {get; set;}
    public string Modelo {get; set;}
    public int Ano {
        get => ano; 
        set 
        {
            if(value < 1960 || value > 2023){
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            } else {
                ano = value;
            }
        }
    }
    public int QuantidadePortas{get; set;}
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";
}

//parte 4: desenvolver outra classe, chamada produto
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

    public string DescricaoProduto => $"{this.Nome} {this.Marca} - {this.Preco}";

}