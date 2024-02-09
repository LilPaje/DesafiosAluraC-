/* 


    1- Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
    2- Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova 
propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
    3- Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
    4- Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir 
que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra 
detalhadamente as informações do produto, para que seja usado pela equipe de vendas.


 */


//Parte 1
Console.WriteLine("---Conta Bancária---");
ContaBancaria conta1 = new ContaBancaria();

conta1.NumeroIndicador = 1;
conta1.Titular = "Izzy";
conta1.Saldo = 100.00f;
conta1.Senha = "b4t4t4fr1ta";

conta1.ExibirInformacoesDaConta();


//Parte 2
Console.WriteLine("---Carro---");

Carro carro1 = new Carro();


carro1.AnoDeFabricacao = 2000;
carro1.Modelo = "Corsa";
carro1.Fabricante = "Teste";
carro1.Acelerar();
carro1.Frear();
carro1.Buzinar();



Console.WriteLine(carro1.DescricaoDetalhada);