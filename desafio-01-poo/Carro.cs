//Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar 


class Carro{

	public int velocidade = 0;


	public void Acelerar(){
		velocidade = velocidade + 10;
		Console.WriteLine($"Acelerando... \nVelocidade atual: {velocidade}");
	}

	public void Frear(){
		velocidade = velocidade -10;
		Console.WriteLine($"Freando... \nVelocidade atual: {velocidade}");
	}

	public void Buzinar(){
		Console.WriteLine("Buzinando: BIP BIP");
	}
}