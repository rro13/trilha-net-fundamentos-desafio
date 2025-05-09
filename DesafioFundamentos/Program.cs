using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorMinuto = 0;
string inputPrecoInicial = "";
string inputPrecoPorMinuto = "";

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
while(inputPrecoInicial is string) {
    inputPrecoInicial = Console.ReadLine();
    if(decimal.TryParse(inputPrecoInicial, out precoInicial)) {
        break;
    } else {
    Console.Clear();
    Console.WriteLine("Digite um valor válido.");
}
}

Console.WriteLine("Agora digite o preço por minuto:");
while(inputPrecoPorMinuto is string) {
    inputPrecoPorMinuto = Console.ReadLine();
    if(decimal.TryParse(inputPrecoPorMinuto, out precoPorMinuto)) {
        break;
    } else {
    Console.Clear();
    Console.WriteLine("Digite um valor válido.");
}
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorMinuto);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
