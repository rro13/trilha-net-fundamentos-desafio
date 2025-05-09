namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorMinuto = 0;
        private List<string> veiculos = new List<string>();

        private DateTime horaChegada = DateTime.Now;
        public Estacionamento(decimal precoInicial, decimal precoPorMinuto)
        {
            this.precoInicial = precoInicial;
            this.precoPorMinuto = precoPorMinuto;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            horaChegada = DateTime.Now;
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placaParaRemover = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaParaRemover.ToUpper()))
            {
                DateTime horaSaida = DateTime.Now;
                decimal valorTotal = 0;
                TimeSpan minutosEstacionados = horaSaida - horaChegada;

                Console.WriteLine($"Horário de entrada {horaChegada}\n"
                                + $"Horário de saída {horaSaida}\n"
                                + $"Minutos estacionadas {minutosEstacionados.Minutes}");

                valorTotal = precoInicial + (precoPorMinuto * minutosEstacionados.Minutes);
                
                veiculos.Remove(placaParaRemover);
                Console.WriteLine($"O veículo {placaParaRemover} foi removido após {minutosEstacionados.Minutes} minutos estacionados e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos) 
                {
                    Console.WriteLine(veiculo);
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
