using System;
using System.IO;

public class Client{
  public string Name;
  public string Surname;
  public int Phone_nr;

  public Client(string name, string surname, int phone_nr){
    this.Name = name;
    this.Surname = surname;
    this.Phone_nr = phone_nr;
  }

  public static void WrongInput(){
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
    Console.WriteLine("                                                                      ");
    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
  }  
  
  public static int Input(){
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
  
  //Datu pievienošana
  public void ClientAdd(){
    Console.Clear();
   
    string path = @"Client.txt";

    Console.Write("Client Name: ");
    string Name = Console.ReadLine();
    Console.Write("Client Surname: ");
    string Surname = Console.ReadLine();
    Console.Write("Client Phone_nr: ");
    int Phone_nr = Input();

    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default)){
      sw.WriteLine($"{Name}\n{Surname}\n{Phone_nr}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  //Datu apskate
  int ID_client(string filePath){
    using (StreamReader streamReader = new StreamReader(filePath)){
        int i = 0;
        while (streamReader.ReadLine() != null) { i++; }
        return i;
    }
  }
  
  public void ClientView(){
    Console.Clear();
    string path = @"Client.txt";
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
  public void DeleteClientData(){
    Console.Clear();
    string tempFile = Path.GetTempFileName();
    string path = @"Client.txt";
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
      Console.Write("Enter ID of client you want to remove: ");
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
      File.Delete("Client.txt");
      File.Move(tempFile, "Client.txt");
    }
  }
  
  //Search Data
  public void SearchClientData(){
    Console.Clear();

    int counter = 0;
    string line;

    Console.Write("Input your search text: ");
    var text = Console.ReadLine();

    System.IO.StreamReader file =
    new System.IO.StreamReader("Client.txt");

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
    
  //Summary
    
  public void SummaryClientData(){
    Console.Clear();
    
  }
  //Sort

  public void SortClientData() {
    Console.Clear();
    
  }
}