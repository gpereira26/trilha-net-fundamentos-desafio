namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (Veiculos.Contains(placa) == false) Veiculos.Add(placa); // confere se já existe a placa
            else Console.WriteLine("A placa já existe!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                Veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string placa in Veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Estacionamento)) return false;
            Estacionamento other = obj as Estacionamento;
            return Veiculos.Equals(other.Veiculos);
        }
        public override int GetHashCode()
        {
            return Veiculos.GetHashCode();
        }
    }
}
