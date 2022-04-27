using System;
using System.IO;

public class Menu : Cafe{
  public string Name;
  public string Type;
  public double Price;

  public Menu(string name, string type, double price){
    this.Name = name;
    this.Type = type;
    this.Price = price;
  }

  //Food type picker
  static string FoodType(){
    try {
      int sk = Convert.ToInt32(Console.ReadLine());
      if (sk == 1){
        string Type = "food";
        return Type;
      }
      else if(sk == 2){
        string Type = "drink";
        return Type;
      }
      else{
        Console.Write("Choice not in range! Type of item(food = 1 drink = 2): ");
        FoodType();
        return null;
      }
    }
    catch{
      WrongInput();
      Console.Write("Wrong format! Price of the item: ");
      FoodType();
      return null;
    }
  }
  
  //Datu pievienošana
  public static void MenuAdd(){
    Console.Clear();
   
    string path = @"txt/Menu.txt";

    Console.Write("Name of the food or drink: ");
    string Name = Console.ReadLine();
    Console.Write("Type of item(food = 1 drink = 2): ");
    string Type = FoodType();
    Console.Write("Price of the item: ");
    double Price = InputMenu();

    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default)){
      sw.WriteLine($"{Name}\n{Type}\n{Price}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  //Datu apskate
  static int ID_menu(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }
  
  public static void MenuView(){
    Console.Clear();
    string path = @"txt/Menu.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      if (1 > ID_menu(path)){
        Console.WriteLine($"No Data!");
      }
      else{
        for(int i = 1; i <= ID_menu(path) / 3; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Name: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Type: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Price: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
    }
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
  }

  //Delete Data
  public static void DeleteMenuData(){
    Console.Clear();
    string tempFile = Path.GetTempFileName();
    string path = @"txt/Menu.txt";
    if (1 > ID_menu(path)){
      Console.WriteLine($"No Data to delete!");
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();
    }
    else{
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
        for(int i = 1; i <= ID_menu(path) / 3; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Name: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Type: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Price: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
      Console.Write("Enter ID of food on the menu you want to remove: ");
      int number = Izvele();
      int obj = 1 + (3*(number-1));
      Console.WriteLine(obj);
      int line_number = 0;
      string line;
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default))
      using(StreamWriter streamWriter = new StreamWriter(tempFile)){
        while((line = streamreader.ReadLine()) != null) {
          line_number++;
          if (line_number < obj || line_number > obj+2){
            streamWriter.WriteLine(line);
          }
        }
      }
      File.Delete("txt/Menu.txt");
      File.Move(tempFile, "txt/Menu.txt");
    }
  }
  
  //Search Data
  public static void SearchMenuData(){
    Console.Clear();
    
  }

  //Sort

  public static void SortMenuData(){
    Console.Clear();
    
  }
}