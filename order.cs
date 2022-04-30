using System;
using System.IO;

public class Order : Cafe{
  public int Food;
  public double Price;
  public double Total_price;

  public Order(int food, double price, double total_price){
    this.Food = food;
    this.Price = price;
    this.Total_price = total_price;
  }

  static int ID_menu(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }
  
  //Datu pievienošana
  public static void OrderAdd(){
    Menu.MenuView();
    string path = @"txt/Order.txt";
    double Price = 0;
    Console.Write("How many dishes will be ordered: ");
    int Food = Convert.ToInt32(Console.ReadLine());
    double Total_price = 0; 
    for (int i = 1; i <= Food; i++){
      Console.Write($"Price for food {i}: ");
      Price = Convert.ToDouble(Console.ReadLine());
      Total_price += Price;
    }
    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default)){
      sw.WriteLine($"{Food}\n{Total_price}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  
  static int ID_order(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }
  

  //Datu apskate
  public static void OrderView(){
    Console.Clear();
    string path = @"txt/Order.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      if (1 > ID_order(path)){
        Console.WriteLine($"No Data to View!");
      }
      else{
        for(int i = 1; i <= ID_order(path) / 2; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Food ordered: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Total price: ");
          Console.Write(streamreader.ReadLine());
          Console.WriteLine("€");
          Console.WriteLine();
        }
      }
    }
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
  }

  //Delete Data
  public static void DeleteOrderData(){
    Console.Clear();

    string tempFile = Path.GetTempFileName();
    string path = @"txt/Order.txt";
    if (1 > ID_order(path)){
      Console.WriteLine($"No Data to delete!");
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();
    }
    else{
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
        for(int i = 1; i <= ID_order(path) / 2; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Food: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Total price: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
      Console.Write("Enter ID of order you want to remove (0 to go back): ");
      int number = Izvele();
      if (number == 0){
        Interface.MainMenu();
      }
      int obj = 1 + (2*(number-1));
      Console.WriteLine(obj);
      int line_number = 0;
      string line;
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default))
      using (StreamWriter streamWriter = new StreamWriter(tempFile)){
        while ((line = streamreader.ReadLine()) != null) {
          line_number++;
          if (line_number < obj || line_number > obj+1){
            streamWriter.WriteLine(line);
          }
        }
      }
      File.Delete("txt/Order.txt");
      File.Move(tempFile, "txt/Order.txt");
    }
  }
  
  //Search Data
  public static void SearchOrderData(){
    Console.Clear();

  }
    
  //Sort

  public static void SortOrderData(){
    Console.Clear();
    
  }
}