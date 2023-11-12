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
           
            if (  Suite.Capacidade >= hospedes.Capacity)
            {
                
                Hospedes = hospedes;
            }
            else
            {
                
try
{
     Hospedes = hospedes;
}
catch (Exception)
{
                    Console.WriteLine("Ocorreu um erro , não há suites suficientes");
}
                

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

           
            if (valor >= 10)
            {
                valor = valor -  valor * 10  / 100;
            }

            return valor;
        }
    }
}