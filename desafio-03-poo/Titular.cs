class Titular{
	public string nome;
	private int cpf; 

	public int CpfProp {get => cpf;
		set {
			if(value >0){cpf = value;}
			else {Console.WriteLine("Opção Inválida");}
			
		}
	}
}