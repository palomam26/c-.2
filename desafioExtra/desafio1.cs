//parte 1 : criar uma classe para uma conta bancária
class Conta{
    public string titular;
    public int idConta;
    public float saldo;
    public int senha;
}

//parte 2 : objeto tipo conta
Conta conta = new Conta();
conta.titular = "Gui Lima";
conta.id = 1;
conta.saldo = 20.00;
conta.senha = 1234;

Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.titular}"); 
Console.WriteLine($"Saldo atual: {conta.saldo}");

//parte 3: desenvolver um método da classe conta
public void exibirInformacoes(){
    Console.WriteLine("INFORMAÇÕES DA CONTA:");
    Console.WriteLine($"Titular: {this.titular}"); 
    Console.WriteLine($"Saldo atual: {this.saldo}");
}

//parte 4: classe carro com métodos
class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
    public int velocidade = 0;

    public void exibirInformacoes(){
        Console.WriteLine($"Informações do carro: {this.fabricante} {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }
    
    public void acelerar(){
        Console.WriteLine("Acelerando...");
        if(velocidade < 100){
            velocidade = velocidade + 5;
        }
    }

    public void frear(){
        Console.WriteLine("Freando...");
        if(velocidade > 0){
            velocidade = velocidade - 5;
        }
    }

    public void buzinar(){
        Console.WriteLine("Bi Bi");
    }
}
