namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal horaVeiculo = 0;
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"A placa digitada foi: {placa.ToUpper()}");
        }


        public void RemoverVeiculo()
        {
            
            string placaRemover = "";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placaRemover = Console.ReadLine();

            //Se a placa não estiver correta o programa pede para digita-la novamente
            while (veiculos.Any(x => x.ToUpper() != placaRemover.ToUpper()))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.WriteLine($"A placa digitada foi: {placaRemover.ToUpper()}");

                Console.WriteLine("\nDigite a placa do veículo para remover:");
                placaRemover = Console.ReadLine();
            }

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horaVeiculo = Convert.ToDecimal(Console.ReadLine());

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                /*int horas = 0;
                decimal valorTotal = 0; */

                decimal valorTotal = precoInicial + precoPorHora * horaVeiculo;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placaRemover.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placaRemover);
            }
        }
        

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                for (int contador = 0;contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"Posição N° {contador + 1}° - {veiculos[contador].ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
