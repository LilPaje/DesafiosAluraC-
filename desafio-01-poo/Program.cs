/*  Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
    Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
    Desenvolver um método da classe Conta que exibe suas informações.
    Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar */


//Parte 1
Console.WriteLine("---Conta Bancária---");
ContaBancaria conta1 = new ContaBancaria();

conta1.numeroIndicador = 1;
conta1.titular = "Izzy";
conta1.saldo = 100.00f;
conta1.senha = "b4t4t4fr1ta";

conta1.ExibirInformacoesDaConta();


//Parte 2
Console.WriteLine("---Carro---");

Carro carro1 = new Carro();

carro1.Acelerar();
carro1.Frear();
carro1.Buzinar();