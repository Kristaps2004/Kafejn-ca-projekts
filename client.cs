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
  
  //Datu pievienošana
  public void ClientAdd(){
    Console.Clear();
   
    string path = @"Client.txt";

    Console.Write("Client Name: ");
    string Name = Console.ReadLine();
    Console.Write("Client Surname: ");
    string Surname = Console.ReadLine();
    Console.Write("Client Phone_nr: ");
    string Phone_nr = Console.ReadLine();

    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default)){
      sw.WriteLine($"{Name}\n{Surname}\n{Phone_nr}");
    }
    Console.WriteLine("Succes! Press any key to continue!");
    Console.ReadKey();
  }

  //Datu lasīšana
  int ID_client(string filePath){
    using (StreamReader r = new StreamReader(filePath)){
        int i = 0;
        while (r.ReadLine() != null) { i++; }
        return i;
    }
  }
  
  public void ClientView(){
    Console.Clear();
    string path = @"Client.txt";
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

  //Delete Data
  public void DeleteClientData(){
    Console.Clear();
    string tempFile = Path.GetTempFileName();
    string path = @"Client.txt";
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
    int number = Convert.ToInt32(Console.ReadLine());
    int obj = 1 + (3*(number-1));
    Console.WriteLine(obj);
    //Hz
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
    //
    File.Delete("Client.txt");
    File.Move(tempFile, "Client.txt");
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
  }
  
  //Search Data
  public void SearchClientData(){
    Console.Clear();
    
  }
    
  //Summary
    
  public void SummaryClientData(){
    Console.Clear();
    
  }
  //Sort

  public void SortClientData(){
    Console.Clear();
    
  }
}