using System;
using System.IO;

class Summary{
  static int ID (string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
      int i = 0;
      while (streamReader.ReadLine() != null) { i++; }
      return i;
    }
  }
    
  public static void Info(){
    int clients = ID ("txt/Client.txt") / 3;
    int foods = ID ("txt/Menu.txt") / 3;
    int orders = ID ("txt/Order.txt") / 2;
    Console.Clear();
    Interface.Banner();
    Console.WriteLine();
    Console.WriteLine($"Total clients: {clients}");
    Console.WriteLine($"Total foods on menu: {foods}");
    Console.WriteLine($"Total orders: {orders}");
    Console.WriteLine("____________________________________________________");
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
    Console.Clear();
    Interface.MainMenu();
  }
}