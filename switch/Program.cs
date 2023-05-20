using System;

namespace abc
{
  class Program
  {

    
    static void Main(string [] args)
    {
      int month =DateTime.Now.Month;
      
      //expression
      switch (month)
      {
        case 1:
        Console.WriteLine("Ocak ayındasınız");
        break;
        case 2:
        Console.WriteLine("Subat ayındasınız");
        break;  
        case 5:
        Console.WriteLine("mayıs ayındasınız");
        break;      
        
        default:
        break;
      }
    switch (month)
      {
        case 12:
        case 1:
        case 2:
        Console.WriteLine("Kis ayındasınız");
        break;
        case 3:
        case 4:
        case 5:
        Console.WriteLine("ilkbahar ayındasınız");
        break;  
        case 6:
        case 7:
        case 8:
        Console.WriteLine("yaz ayındasınız");
        break;
        case 9:
        case 10:
        case 11:
        Console.WriteLine("sonbahar ayındasınız");
        break;      
        
        default:
        break;
      }

    }
  }
}