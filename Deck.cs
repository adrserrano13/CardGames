using System;

namespace Practica2.DINT
{
    public class Deck{


      Card[] cards = new Card[52];//creamos un array de 52 cartas
      int next=-1;//variable para usar en metodo nextElement

     public Deck(){}
     public void CreateCards(){

       //variable que usaremos para crear la baraja
        int c=0;
        //creamos 13 cartas de corazones
        for(int i = 1; i<14; i++){
         cards[c] = new Card(ESuits.Hearts, (EValue) i);
         c++;
        }
        //creamos 13 cartas de diamantes
        for(int i = 1; i<14; i++){
         cards[c] = new Card(ESuits.Diamonds, (EValue) i);
         c++;
        }
        //creamos 13 cartas de picas
        for(int i = 1; i<14; i++){
         cards[c] = new Card(ESuits.Spades, (EValue) i);
         c++;
        }
        //creamos 13 cartas de trebol
        for(int i = 1; i<14; i++){
         cards[c] = new Card(ESuits.Clubs, (EValue) i);
         c++;
        }
      }
      //metodo para mostrar las cartas
      public void ShowCards(){

      for(int i=0; i< cards.Length;i++)
          Console.WriteLine(cards[i]);
      }
      //metodo para sacar la siguiente carta
      public Card nextElement(){

        if(next < cards.Length){

          next++;
          return cards[next];
        }
        else
          return null;
      }
      //metodo para barajar las cartas
      public void Shuffle(){

        Card aux =  new Card();
        var random = new Random();

        int j;
         for(int i=0;i<cards.Length;i++){

            j = random.Next(0, 52);

            aux = cards[i];
            cards[i] = cards[j];
            cards[j] = aux;
         }
      }

    }
}
