using System;
using System.IO;

public class Menu : Cafe{
  public string FoodName;
  public string Type;
  public double Price;

  public Menu(string foodname, string type, double price){
    this.FoodName = foodname;
    this.Type = type;
    this.Price = price;
  }

  //Data picker
  public static string Picker(){
    string Type;
    bool success = true;
    ConsoleKeyInfo izvele;
    do{
      izvele = Console.ReadKey();
      if (izvele.KeyChar == '1'){
        Type = "food";
        success = false;
        return Type;
      }
      else if (izvele.KeyChar == '2'){
        Type = "drink";
        success = false;
        return Type;
      }
    }while(success == true);
    return null;
  }
   
  //Datu pievienošana
  public static void MenuAdd(){
    Console.Clear();
   
    string path = @"txt/Menu.txt";

    Console.Write("Name of the food or drink: ");
    string FoodName = Console.ReadLine();
    Console.Write("Type of item(food = 1 drink = 2): ");
    string Type = Picker();
    Console.Write("\nPrice of the item: ");
    double Price = InputMenu();

    using (StreamWriter streamWriter = new StreamWriter(path, true, System.Text.Encoding.Default)){
      streamWriter.WriteLine($"{FoodName}\n{Type}\n{Price}");
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
        for (int i = 1; i <= ID_menu(path) / 3; i++){
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
        for (int i = 1; i <= ID_menu(path) / 3; i++){
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
      Console.Write("Enter ID of food on the menu you want to remove(0 to go back): ");
      int number = Izvele();
      if (number == 0){
        Interface.MainMenu();
      }
      int ID = 1 + (3*(number-1));
      Console.WriteLine(ID);
      int line_number = 0;
      string line;
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default))
      using (StreamWriter streamWriter = new StreamWriter(tempFile)){
        while ((line = streamreader.ReadLine()) != null) {
          line_number++;
          if (line_number < ID || line_number > ID+2){
            streamWriter.WriteLine(line);
          }
        }
      }
      File.Delete("txt/Menu.txt");
      File.Move(tempFile, "txt/Menu.txt");
    }
  }
  
  //Search Data
  public static void SearchMenuData(int num){
    Console.Clear();
    string path = @"txt/Menu.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      for (int i = num; i <= ID_menu(path); i+= 3){
          if (i < 3){
            for (int x = 1; x < i; x++){
              streamreader.ReadLine();
            }
          }
          else{
            for (int x = i-2; x < i; x++){
              streamreader.ReadLine();
            }
          }
        if (num == 1){
          Console.Write($"Name of Food: ");
        }
        else if (num == 2){
          Console.Write($"Food type: ");
        }
        else if (num == 3){
          Console.Write($"Price: ");
        }
          Console.WriteLine(streamreader.ReadLine());
        }
    }
    Console.WriteLine("\nPress any key to continue!");
    Console.ReadKey();
  }

  //Sort
  public static void SortMenuData(){
    Console.Clear();
    Console.Write(@"Choose sort method:
1. A-Z
2. Z-A
Type number: ");
    ConsoleKeyInfo izvele;
    izvele = Console.ReadKey();
    string inFile = @"txt/Menu.txt";
    var contents = File.ReadAllLines(inFile);
    Console.WriteLine("");
    if (izvele.KeyChar == '1'){
      Console.ReadKey();
      Array.Sort(contents); //A-Z
      for (int i = 0; i < contents.Length; i++){
        Console.WriteLine(contents[i]);
      }
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();
    }
    else if(izvele.KeyChar == '2'){
      Console.ReadKey();
      Array.Sort(contents); 
      Array.Reverse(contents); //Z-A
      for (int i = 0; i < contents.Length; i++){
        Console.WriteLine(contents[i]);
      }
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();  
    }
    else{
      SortMenuData();
      Console.ReadKey();
    }
  }
}