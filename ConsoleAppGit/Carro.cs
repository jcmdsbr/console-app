
namespace ConsoleAppGit;

public class Carro
{
    public string Placa { get; set; }
    public string Cor { get; set; }
    public int Potencia { get; set; }
    public bool Flex { get; set; }
    public Dono Dono { get; set; }

    public Carro(string placa, string cor, int potencia, bool flex, Dono dono)
    {
        Placa = placa;
        Cor = cor;
        Potencia = potencia;
        Flex = flex;
        Dono = dono;
    }

    public string GetCRLV() => "DADOS DO DOCUMENTO DO CARRO";
}