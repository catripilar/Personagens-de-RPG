namespace rpg.Personagem{
    public class Heroi{
       public Heroi(string nome,int nivel,string tipo){
           this.nome = nome;
           this.nivel = nivel;
           this.tipo = tipo;
       }
       public Heroi(){}
       public string nome;
       public string tipo;
       public int nivel; 

       public override string ToString(){
           return "Nome:"+this.nome+"  Nivel:"+this.nivel+"  Tipo:"+this.tipo;
           }
       public virtual string Ataque(string arma,int força){
        if(força > 7){return this.nome+"-atacou com poderosíssima "+arma+"!";}
        else{return this.nome+"-atacou com "+arma+"!";}
        }
    }
}