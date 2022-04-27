using System;


public abstract class Cafe {
  public static void WrongInput(){
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.WriteLine("                                                                      ");
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
  } 

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
  /*//Dati par klientu - Data about client
  protected string name;
  public string Name
  {
    get {return name;}
  }
  protected string surname;
  public string Surname
  {
    get {return surname;}
  }
  protected int phone_nr;
  public int Phone_NR
  {
    get {return phone_nr;}
  }

  //Dati par ēdienkarti - Data about menu
  protected string food;
  public string Food
  {
    get {return food;}
  }
  protected string drinks;
  public string Drinks
  {
    get {return drinks;}
  }
  protected double price;
  public double Price
  {
    get {return price;}
  }
  protected int amount;
  public int Amount
  {
    get {return amount;}
  }

  //Dati par pasūtījumu - Data about order
  protected double total_price;
  public double Total_price
  {
    get {return total_price;}
  }
  protected int check_nr;
  public int Check_NR
  {
    get {return check_nr;}
  }
  protected int table_nr;
  public int Table_NR
  {
    get {return table_nr;}
  }
}*/
