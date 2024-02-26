/*
1- Criar um construtor para a classe Titular, que inicialize 
todas suas propriedades:
*/


class Titular{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Endereco {get; set;}

    public Titular(string nome, string cpf, string endereco){
    	Nome = nome;
    	Cpf = cpf;
    	Endereco = endereco;
    }
}
