using System;
using System.IO;

public class Client : Cafe{
  public string Name;
  public string Surname;
  public int Phone_nr;

  public Client(string name, string surname, int phone_nr){
    this.Name = name;
    this.Surname = surname;
    this.Phone_nr = phone_nr;
  }

  static int ID_client(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }
  
  //Datu pievienošana
  public static void ClientAdd(){
    Console.Clear();
    string path = @"txt/Client.txt";

    Console.Write("Client Name: ");
    string Name = Console.ReadLine();
    Console.Write("Client Surname: ");
    string Surname = Console.ReadLine();
    Console.Write("Client Phone_nr: ");
    int Phone_nr = InputClient();

    using (StreamWriter streamWriter = new StreamWriter(path, true, System.Text.Encoding.Default)){
      streamWriter.WriteLine($"{Name}\n{Surname}\n{Phone_nr}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  //Datu apskate
  public static void ClientView(){
    Console.Clear();
    string path = @"txt/Client.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      if (1 > ID_client(path)){
        Console.WriteLine($"No Data to View!");
      }
      else{
        for (int i = 1; i <= ID_client(path) / 3; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Name: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Surname: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Phone_nr: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
    }
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
  }

  //Delete Data
  public static void DeleteClientData(){
    Console.Clear();
    string tempFile = Path.GetTempFileName();
    string path = @"txt/Client.txt";
    if (1 > ID_client(path)){
      Console.WriteLine($"No Data to delete!");
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();
    }
    else{
      using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
        for (int i = 1; i <= ID_client(path) / 3; i++){
          Console.Write($"ID: {i}\n");
          Console.Write($"Name: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Surname: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.Write($"Phone_nr: ");
          Console.WriteLine(streamreader.ReadLine());
          Console.WriteLine();
        }
      }
      Console.Write("Enter ID of client you want to remove (0 to go back): ");
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
      File.Delete("txt/Client.txt");
      File.Move(tempFile, "txt/Client.txt");
    }
  }
  
  //Search Data
  public static void SearchClientData(int num){
    Console.Clear();
    string path = @"txt/Client.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      for (int i = num; i <= ID_client(path); i+= 3){
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
          Console.Write($"Name of the clients: ");
        }
        else if (num == 2){
          Console.Write($"Surname of the clients: ");
        }
        else if (num == 3){
          Console.Write($"Phone numbers of the clients: ");
        }
          Console.WriteLine(streamreader.ReadLine());
        }
    }
    Console.WriteLine("\nPress any key to continue!");
    Console.ReadKey();
  }
    
  //Sort
  public static void SortClientData() {
    Console.Clear();
    Console.Write(@"Choose sort method:
1. A-Z 
2. Z-A
Type number: ");
    ConsoleKeyInfo izvele;
    izvele = Console.ReadKey();
    string inFile = @"txt/Client.txt";
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
      SortClientData();
      Console.ReadKey();
    }
  }
}