/* 


    1- Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
    2- Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova 
propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
    3- Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
    4- Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir 
que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra 
detalhadamente as informações do produto, para que seja usado pela equipe de vendas.


 */

class Carro{

	private int ano;
	public string Fabricante { get; set; }
	public int Velocidade = 0;
	public string Modelo { get; set; }
	public int AnoDeFabricacao { 
		get => ano; 
		set {
			if (value >= 1960 && value <= 2023){
				ano = value;
			} else {
				Console.WriteLine($"O valor {value} é inválido, tente novamente");
			}

			}
		}
	public int QuantidadeDePortas { get; set; }
	public string DescricaoDetalhada => $"Descrição detalhada: {Fabricante}, {Modelo} e {AnoDeFabricacao}";


	
	public void Acelerar(){
		Velocidade = Velocidade + 10;
		Console.WriteLine($"Acelerando... \nVelocidade atual: {Velocidade}");
	}

	public void Frear(){
		Velocidade = Velocidade -10;
		Console.WriteLine($"Freando... \nVelocidade atual: {Velocidade}");
	}

	public void Buzinar(){
		Console.WriteLine("Buzinando: BIP BIP");
	}
}