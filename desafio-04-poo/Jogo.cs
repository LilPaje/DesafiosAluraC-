/*
4- Desenvolver uma classe que representa um catálogo de 
jogos, com uma lista de Jogos e métodos para manipular essa 
lista, bem como um construtor que faça sua inicialização.
*/

class Jogo{
	public string Nome {get;}
	private float Preco {get; set;}
	private int Quantidade{get; set;}

	public float SetGetPreco{
		get => Preco;
		set{
			if(value > 0){
				Preco = value;
			}
		}
	}

	public int SetGetQuant{
		get => Quantidade;
		set {
			if(value > 0){
				Preco = value;
			}
		}
	}

	public string ExibirJogo {
		get => $"Nome: {Nome}, Preço: {Preco}";
	}

	public Jogo(string nome, float preco, int quantidade){
		Nome = nome;
		Preco = preco; 
		Quantidade = quantidade;

	}

}