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

    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default)){
      sw.WriteLine($"{Name}\n{Surname}\n{Phone_nr}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  //Datu apskate
  static int ID_client(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }
  
  public static void ClientView(){
    Console.Clear();
    string path = @"txt/Client.txt";
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      if (1 > ID_client(path)){
        Console.WriteLine($"No Data to View!");
      }
      else{
        for(int i = 1; i <= ID_client(path) / 3; i++){
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
        for(int i = 1; i <= ID_client(path) / 3; i++){
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
        Program.MainMenu();
      }
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
      File.Delete("txt/Client.txt");
      File.Move(tempFile, "txt/Client.txt");
    }
  }
  
  //Search Data
  public static void SearchClientData(){
    Console.Clear();

    int counter = 0;
    string line;

    Console.Write("Input your search text: ");
    var text = Console.ReadLine();

    System.IO.StreamReader file =
    new System.IO.StreamReader("txt/Client.txt");

    while ((line = file.ReadLine()) != null)
    {
        if (line.Contains(text))
        {
          break;
        }

        counter++;
    }

    Console.WriteLine("Line number: {0}", counter);

    file.Close();

    Console.ReadLine();
  }
    
  //Sort

  public static void SortClientData() {
    Console.Clear();

    string path = @"txt/Client.txt";
    var contents = File.ReadAllLines(path);
    Array.Sort(contents); // Sort alphabetically A-Z
    Array.Reverse(contents); // Sort alphabetically Z-A
    using (StreamReader streamreader = new StreamReader(path,System.Text.Encoding.Default)){
      for(int i = 1; i <= ID_client(path) / 3; i++){
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
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
  }
}