/*
	4- Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno 
deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e 
disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos 
matriculados.
*/

class Disciplina{
	public string nome;
	private List<Aluno> alunosMatriculados = new List<Aluno>();

	public void MatricularAlunos(Aluno aluno){
		alunosMatriculados.Add(aluno);
	}

	public void ExibirDisciplina(){
		Console.WriteLine("---Exibindo Informações da Disciplina---");
		Console.WriteLine($"Nome: {nome}\nAlunos Matriculados: ");
		foreach(Aluno aluno in alunosMatriculados){
			Console.WriteLine($"{aluno.nome}");
		}
		Console.WriteLine("---------------------------------------\n\n");
	}
}