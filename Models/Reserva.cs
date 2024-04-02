namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
              // Implementado
                Console.WriteLine($"Capacidade da suite e inferior ao numero de hospedes");
                Environment.Exit(0);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado           
            decimal valor = Suite.ValorDiaria * DiasReservados;;

            // Implementado
            decimal desconto = 10;
            if (DiasReservados > 10)
            {
                desconto = valor * (desconto / 100);
                valor -= desconto;
            }

            return valor;
        }
    }
}