using System;
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
      // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
      if (Suite.Capacidade >= hospedes.Capacity)
      {
        Hospedes = hospedes;
      }
      else
      {
        // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
        throw new Exception("essa suite não consegue capacitar todo mundo");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
      return Hospedes.Count();
    }

    public double CalcularValorDiaria()
    {
      // TODO: Retorna o valor da diária
      // Cálculo: DiasReservados X Suite.ValorDiaria
      double valor = DiasReservados * Suite.ValorDiaria;

      // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
      if (DiasReservados >= 10)
      {
        valor = valor - (valor * 0.1);
      }

      return valor;
    }
  }
}