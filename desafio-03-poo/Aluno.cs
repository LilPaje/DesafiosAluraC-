/*
	4- Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno 
deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e 
disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos 
matriculados.
*/

class Aluno{
	public string nome;
	public int idade;
	public Dictionary<Disciplina, float> notas = new Dictionary<Disciplina, float>();

	public void AdicionarNotaDaMateria(Disciplina disc, float nota){
		notas.Add(disc, nota);
	}

	public void ExibirAluno(){
		Console.WriteLine("---Exibindo Informações do Aluno---");
		Console.WriteLine($"Nome: {nome}\nIdade: {idade}");
		foreach(Disciplina disc in notas.Keys){
			Console.WriteLine($"{disc.nome}: {notas[disc]}");
		}
		Console.WriteLine("-----------------------------------");
	}

}