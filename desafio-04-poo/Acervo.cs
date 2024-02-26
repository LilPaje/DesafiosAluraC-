/*
4- Desenvolver uma classe que representa um catálogo de 
jogos, com uma lista de Jogos e métodos para manipular essa 
lista, bem como um construtor que faça sua inicialização.
*/

class Acervo{
	List <Jogo> ListaJogos = new List <Jogo>();
	public string Nome {get;}
	public string Endereco {get;}

	public void AdicionarJogoNaLista(Jogo jogo){
		bool adicionar = true;
		foreach(Jogo jogoLista in ListaJogos){
			if(jogo.Nome == jogoLista.Nome){
				adicionar = false;
				break;
			}

		}
		if (adicionar){
			ListaJogos.Add(jogo);
		}
	}

	public string ExibirAcervo {get => $"Nome da Loja: {Nome}, Endereço: {Endereco}";}


	public void RetirarJogoDaLista(Jogo jogo){
		for(int i = 0; i < ListaJogos.Count; i++){
			if (jogo.Nome == ListaJogos[i].Nome){
				ListaJogos.RemoveAt(i);
			}
		}
	}

	public Acervo(string nome, string endereco){
		Nome = nome;
		Endereco = endereco; 
	}

}
