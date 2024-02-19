/*
    1- Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da 
conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações 
da conta de forma detalhada.
    2- Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a 
partir da Conta.
    3- Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de 
adicionar novos produtos, e exibir todos os produtos no estoque.
    4- Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno 
deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e 
disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos 
matriculados.
    5- Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A 
classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser 
pedidos. Os pedidos podem estar associados a uma mesa.

*/
//Desafio 1
Titular titular1 = new Titular();
Conta conta1 = new Conta();

titular1.nome = "Izzy Costa";
titular1.CpfProp = 12348;

conta1.Titular = titular1;
conta1.agencia = 1;
conta1.numeroDaConta = 2;
conta1.saldo = 0.1f;
conta1.limite = 0.2f;

Console.WriteLine(conta1.InformacoesDetalhadas());

//Desafio 2

Console.WriteLine(conta1.InformacoesTitular());

//Desafio 3

Produto produto1 = new Produto();
produto1.nome = "celular";
produto1.valor = 1.1f;

Estoque estoque1 = new Estoque();
estoque1.AdicionarNovoProduto(produto1, 2);

estoque1.ExibirProdutosNoEstoque();

//Desafio 4