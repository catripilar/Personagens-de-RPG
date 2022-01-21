using System;
using rpg.Personagem;
namespace rpg{
    class Program{
        static void Main(string[] args){
            Heroi artur = new Heroi("Artur",3,"Guerreiro");
            Heroi Veniquin = new Heroi("Veniquin",8,"Arqueiro");
            Mago Edir = new Mago("Edir",5,"Mago");
            Console.WriteLine(artur);
            Console.WriteLine(Edir);
            Console.WriteLine(Veniquin);
            Console.WriteLine("");
            Console.WriteLine(artur.Ataque("Espada",4));
            Console.WriteLine(Edir.Ataque("bola de fogo",7));
            Console.WriteLine(Veniquin.Ataque("Chuva de Flechas",9));
        }
    }
}
