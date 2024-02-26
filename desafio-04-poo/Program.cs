/*
1- Criar um construtor para a classe Titular, que inicialize 
todas suas propriedades:

2- Criar um construtor para a classe Conta, que inicialize 
todas suas propriedades:

3- Instanciar uma Conta e exibir suas informações na tela, 
utilizando construtores.

4- Desenvolver uma classe que representa um catálogo de 
jogos, com uma lista de Jogos e métodos para manipular essa 
lista, bem como um construtor que faça sua inicialização.
*/

//parte 1 até 3
Titular titular1 = new Titular("Izzy", "000.000.000-00", "Tv X 1234");
Conta conta1 = new Conta(titular1, 0, 1, 1.2f, 3.4f);

Console.WriteLine(conta1.Informacoes); 


//parte 4
Jogo jogo1 = new Jogo("Red Dead Redemption 2", 98.90f, 1);

Console.WriteLine(jogo1.ExibirJogo);

Acervo acervo1 = new Acervo("Casa dos Jogos", "Tv x 5678");

acervo1.AdicionarJogoNaLista(jogo1);

Console.WriteLine(acervo1.ExibirAcervo);

acervo1.RetirarJogoDaLista(jogo1);