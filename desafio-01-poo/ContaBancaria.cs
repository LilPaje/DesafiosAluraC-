/*  Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
    Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, 
utilizando interpolação de strings.
    Desenvolver um método da classe Conta que exibe suas informações.
    Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar */


class ContaBancaria{
    public int numeroIndicador;
    public string titular;
    public float saldo;
    public string senha;

    public void ExibirInformacoesDaConta(){
        Console.WriteLine($"Número indicador da conta: {numeroIndicador}");
        Console.WriteLine($"Titular da conta: {titular}");
        Console.WriteLine($"Saldo da conta: {saldo}");
    }
}