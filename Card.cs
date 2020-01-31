namespace Practica2.DINT{

  //enum para los palos de las cartas
  public enum ESuits{Hearts,Diamonds,Spades,Clubs}
  //enum para los valores de las cartas
  public enum EValue{AS=1,DOS=2,TRES=3,CUATRO=4,CINCO=5,SEIS=6,SIETE=7,OCHO=8,NUEVE=9,DIEZ=10,J=11,Q=12,K=13}

  public class Card{

    //atributos
     protected ESuits suit;
     protected EValue value;
     protected string valor;

     //constructores
     public Card(){}
     public Card(ESuits s,EValue v){

      suit = s;
      value = v;
     }
     //getter para obtener el palo de la carta
     public string getSuit(){
       return string.Format("{0}",suit);
     }
     //getter para obtener el valor de la carta
     public string getValue(){
       return string.Format("{0}",(int) value);
     }
     //metodo tostring para la salida
     public override string ToString(){
      return string.Format("{0} of {1}",value, suit);
     }
    }
}
