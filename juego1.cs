using System;

namespace Practica2.DINT{

  class program{

    public static void Main(string[] args)
    {

      int num, cont=1;//contador para no pasar de 52 veces que podemos sacar carta

      Deck myDeck = new Deck();

      //creamos la baraja de cartas
      myDeck.CreateCards();
      //barajamos las cartas
      myDeck.Shuffle();
      Console.WriteLine("\nBarajando cartas...");


      Console.WriteLine("Pusa 1 para sacar carta");
      bool numero = Int32.TryParse(Console.ReadLine(), out num);

      if(numero == true){

        while(num == 1 && cont <= 52){
          //incrementamos cont
          cont++;
          //imprimirmos la carta por pantalla
          Console.WriteLine("CARTA: {0}",myDeck.nextElement());
          Console.WriteLine("Pusa 1 para sacar carta");
          numero = Int32.TryParse(Console.ReadLine(), out num);


        }
        if(cont == 52)
          Console.WriteLine("No quedan cartas por sacar");
      }
    }
  }
}
