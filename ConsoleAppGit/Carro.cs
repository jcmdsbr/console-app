
namespace ConsoleAppGit;

public class Carro
{
    public string Placa { get; set; }
    public string Cor { get; set; }
    public int Potencia { get; set; }
    public bool Flex { get; set; }

    public Carro(string placa, string cor, int potencia, bool flex)
    {
        Placa = placa;
        Cor = cor;
        Potencia = potencia;
        Flex = flex;
    }

    public void Acelerar() {
        // Implementação acelerar
    }

    public void Frear(){
        // Implementação Frear
    }

    public string GetCRLV() => "DADOS DO DOCUMENTO DO CARRO";


    public void Acelerar()
    {
        var valor = 2;
        // Implementação acelerar
    }

    public void Frear()
    {
        // Implementação Frear
    }
}