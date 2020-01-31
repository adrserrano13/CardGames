using System;

namespace Practica2.DINT{

  class juego2{

    public static void Main(string[] args)
    {
      //creamos objetos necesarios
      Deck myDeck = new Deck();
      Card[] card = new Card[5];
      Card[] limit = new Card[52];

      int num;

      //creamos y barajamos las cartas
      myDeck.CreateCards();
      myDeck.Shuffle();
      Console.WriteLine("\nBarajando cartas...");

      Console.WriteLine("Pusa 1 para sacar 5 carta");
      bool numero = Int32.TryParse(Console.ReadLine(), out num);

      while(limit.Length > 0){

        if(limit.Length < 5){
          Console.WriteLine("****Se acabaron las cartas*****");
          break;
        }
        //variables para contar los palos
        int contHearts=0,contSpades=0,contCLubls=0,contDiamonds=0;

        if(numero == true){
          //for para sacar cinco cartas y guardar sus palos
          for(int i =0 ; i<card.Length; i++){

            card[i] = myDeck.nextElement();

            Console.WriteLine(card[i]);

            if(card[i].getSuit().Equals("Hearts"))
              contHearts++;

            if(card[i].getSuit().Equals("Diamonds"))
              contDiamonds++;

            if(card[i].getSuit().Equals("Spades"))
              contSpades++;

            if(card[i].getSuit().Equals("Clubs"))
              contCLubls++;

          }
        }
        else{
          Console.WriteLine("****Tecla pulsada incorrecta****");
        }
        //si alguna de las variables es mayor que 3
        if(contHearts >= 3 || contSpades >=3 || contDiamonds >=3 || contCLubls >=3){
          Console.WriteLine();
          Console.WriteLine("Enhorabuena, ganates");
          break;
        }
        Console.WriteLine();
        Console.WriteLine("Intentalo de nuevo");
        Array.Resize(ref limit, limit.Length - 5);//quitamos 5 cartas del array ya que ya las hemos sacado de la baraja
        Console.WriteLine();
        Console.WriteLine("Pusa 1 para sacar 5 carta");
        numero = Int32.TryParse(Console.ReadLine(), out num);
      }
    }

  }
}
