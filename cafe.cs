using System;

public abstract class Cafe {
  //Clr last line
  public static void WrongInput(){
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.WriteLine("                                                                      ");
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
  } 

  //Try catch wrong input
  public static int InputClient(){
    while (true){
      try {
        int number = Convert.ToInt32(Console.ReadLine());
        return number; 
      }
      catch {
        WrongInput();
        Console.Write("Wrong format! Client Phone_nr: ");
      }
    }
  }

  //Choice range 
  public static int Izvele(){
    while (true){
      try {
        int number = Convert.ToInt32(Console.ReadLine());
        return number; 
      }
      catch {
        WrongInput();
        Console.Write("Choice not in range! Enter Your choice: ");
      }
    }
  }
  
  //Try catch wrong input
  public static double InputMenu(){
    while (true){
      try {
        double number = Convert.ToDouble(Console.ReadLine());
        return number; 
      }
      catch {
        WrongInput();
        Console.Write("Wrong format! Price of the item: ");
      }
    }
  }
}