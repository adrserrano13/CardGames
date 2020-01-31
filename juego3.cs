//Juego del 7 y medio
using System;

namespace Practica2.DINT{

  class juego3{

    public static void Main(string[] args)
    {
      //creamos los objetos necesarios
      Deck myDeck = new Deck();
      Card card = new Card();

      int num;
      double cardValue = 0;

      //creamos la baraja y barajamos
      myDeck.CreateCards();
      myDeck.Shuffle();
      Console.WriteLine("\nBarajando cartas...");

      Console.WriteLine("Pusa 1 para sacar carta 2 para plantarse");
      bool numero = Int32.TryParse(Console.ReadLine(), out num);

      if(numero == true){
        while(num == 1){

          //sacamos una carta
          card = myDeck.nextElement();
          Console.WriteLine("La carta sacada es {0}" ,card);

          //si la carta es menor o igual que 7 cogemos el valor real de la carta
          if(Double.Parse(card.getValue()) <=7.0)

            cardValue += Double.Parse(card.getValue());

          //sino cogemos 0.5
          else
            cardValue += 0.5;

          //Si nos pasamos de 7 y medio perdemos
          if(cardValue > 7.5){

            Console.WriteLine("Te pasaste, vuelve a intentarlo");
            break;
          }
          if(cardValue == 7.5){
            Console.WriteLine("Has hecho el juego perfecto con un valor de 7.5 Enhorabuena!!");
            break;
          }
          //seguimiento de los puntos que llevamos Actualmente
          Console.WriteLine("Actualmente llevas : {0} puntos" , cardValue);

          //sacamos carta o nos plantamos
          Console.WriteLine("Pusa 1 para sacar carta 2 para plantarse");
          numero = Int32.TryParse(Console.ReadLine(), out num);
        }
        //muestra con cuantos puntos nos hemos plantado
        if(cardValue < 7.5)
          Console.WriteLine("Te has plantado con {0} puntos" , cardValue);
      }
    }
  }
}
