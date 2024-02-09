/* 


    1- Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
    2- Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova 
propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
    3- Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
    4- Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir 
que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra 
detalhadamente as informações do produto, para que seja usado pela equipe de vendas.


 */

class ContaBancaria{
    public int NumeroIndicador {get; set;}
    public string Titular {get;set;}
    public float Saldo {get;set;}
    public string Senha {get;set;}

    public void ExibirInformacoesDaConta(){
        Console.WriteLine($"Número indicador da conta: {NumeroIndicador}");
        Console.WriteLine($"Titular da conta: {Titular}");
        Console.WriteLine($"Saldo da conta: {Saldo}");
    }
}