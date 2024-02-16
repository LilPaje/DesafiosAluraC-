/* 


    1- Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
    2- Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova 
propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
    3- Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
    4- Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir 
que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra 
detalhadamente as informações do produto, para que seja usado pela equipe de vendas.


 */

class Produto{
    public string nome;
    public string marca;
    private float preco;
    private int estoque;

    public float PropPreco {
        get => preco;
        set{
            if (value >= 0){preco = value;} 
                else{Console.WriteLine($"O valor {value} é inválido, tente novamente.");}
        }
    }

    public int PropEstoque {
        get => estoque;
        set {
            if (value >=0){estoque = value;}
            else {Console.WriteLine($"O valor {value} é inválido, tente novamente.");}
        }
    }

    public string InformacoesDetalhadas {
        get => $"Nome: {nome}\nMarca: {marca}\nPreco: {PropPreco}\nEstoque: {PropEstoque}";
    } 
}