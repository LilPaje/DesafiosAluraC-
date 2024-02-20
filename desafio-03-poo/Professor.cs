/*
	4- Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno 
deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e 
disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos 
matriculados.
*/

class Professor{ 
	public string nome;
	public List<Disciplina> disciplinasLecionadas = new List<Disciplina>();

	public void AdicionarDisciplina(Disciplina disc){
		disciplinasLecionadas.Add(disc);
	}

	public void ExibirProfessor(){
		Console.WriteLine("---Exibindo Informações do Professor---");
		Console.WriteLine($"Nome: {nome}\n");
		foreach(Disciplina disc in disciplinasLecionadas){
			Console.WriteLine($"{disc.nome}");
		}
		Console.WriteLine("---------------------------------------\n\n");
	}
}