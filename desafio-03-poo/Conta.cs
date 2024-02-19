/*
	1- Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da 
conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações 
da conta de forma detalhada.
*/

class Conta{
	public Titular Titular = new Titular();
	
	public int agencia;
	public int numeroDaConta;
	public float saldo;
	public float limite;

	




	public string InformacoesDetalhadas(){
		return $"---Informações Detalhadas--- \nTitular: {Titular}\nAgência: {agencia}\nNúmero da Conta:{numeroDaConta} \nSaldo: {saldo} \nLimite: {limite}";
	}

	public string InformacoesTitular(){
		return $"---Informações do Titular--- \nNome: {Titular.nome}\nCPF: {Titular.CpfProp}";
	}

}
