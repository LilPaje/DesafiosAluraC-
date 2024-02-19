/*
	Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de 
adicionar novos produtos, e exibir todos os produtos no estoque.
*/

class Estoque{
	Dictionary<Produto, int> ProdutosRegistrados = new Dictionary<Produto, int>();

	public void AdicionarNovoProduto(Produto produto, int quantidade){
		ProdutosRegistrados.Add(produto, quantidade);

	} 

	public void ExibirProdutosNoEstoque(){
		Console.WriteLine("---Lista de Produtos---");
		foreach(Produto produto in ProdutosRegistrados.Keys){
			Console.WriteLine($"Produto: {produto.nome}; Valor: {produto.valor}; Quantidade: {ProdutosRegistrados[produto]}\n");
		}
	}
}