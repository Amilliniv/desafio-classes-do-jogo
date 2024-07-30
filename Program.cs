using System;

public class Hero
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public Hero(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo;
    }

    public void Atacar()
    {
        string ataque;

        switch (Tipo.ToLower())
        {
            case "mago":
                ataque = "magia";
                break;
            case "guerreiro":
                ataque = "espada";
                break;
            case "monge":
                ataque = "artes marciais";
                break;
            case "ninja":
                ataque = "shuriken";
                break;
            default:
                ataque = "com ataque desconhecido";
                break;
        }

        Console.WriteLine($"O {Tipo} atacou usando {ataque}");
    }
}

public class Program
{
    public static void Main()
    {
        Hero heroi1 = new Hero("Caio", 25, "Mago");
        Hero heroi2 = new Hero("Isadora", 25, "Ninja");
        Hero heroi3 = new Hero("Vinicius", 30, "Guerreiro");
        Hero heroi4 = new Hero("Amanda", 28, "Monge");

        // Exemplo de uso do método atacar
        heroi1.Atacar(); // O Mago atacou usando magia
        heroi2.Atacar(); // O Ninja atacou usando shuriken
        heroi3.Atacar(); // O Guerreiro atacou usando espada
        heroi4.Atacar(); // O Monge atacou usando artes marciais
    }
}