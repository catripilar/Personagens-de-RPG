namespace rpg.Personagem
{
    public class Mago:Heroi{
    public Mago(string nome,int nivel,string tipo){
        this.nome = nome;
        this.nivel = nivel;
        this.tipo = tipo;
    }
    public override string Ataque(string magia,int força){
        if(força >= 7){return this.nome+"-lançou SUPER "+magia+"!";}
        else{return this.nome+"-lançou "+magia+"!";}
        }
    }
}