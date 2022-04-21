using System;
using System.IO;
using System.Collections.Generic;

public class Client{
  public int ID_client = 0; 
  public string Name;
  public string Surname;
  public int Phone_nr;

  public Client(int id_client, string name, string surname, int phone_nr){
    this.ID_client = id_client;
    this.Name = name;
    this.Surname = surname;
    this.Phone_nr = phone_nr;
  }

  //Datu pievienošana
  public void KlientaPievienosana(){
    Console.Clear();
    ID_client = ID_client + 1;
    Console.Write("Client Name: ");
    Name = Console.ReadLine();
    Console.Write("Client Surname: ");
    Surname = Console.ReadLine();
    Console.Write("Client Phone_nr: ");
    Phone_nr = Convert.ToInt32(Console.ReadLine());

    string path = "Client.dat";

    Client[] clients = {
      new Client(ID_client, Name, Surname, Phone_nr)
    };

    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Append))){
      foreach (Client client in clients){
        writer.Write(client.ID_client);
        writer.Write(client.Name);
        writer.Write(client.Surname);
        writer.Write(client.Phone_nr);
      }
      Console.WriteLine("Succes! Press any key to continue!");
      Console.ReadKey();
    }
  }

  //Datu lasīšana
  public void PrecesSkatitDatus(){
    Console.Clear();
    List<Client> client = new List<Client>();
    
    using (BinaryReader reader = new  BinaryReader(File.Open("Client.dat", FileMode.Open))) {
      while (reader.PeekChar() > -1){
        ID_client = reader.ReadInt32();
        Name = reader.ReadString();
        Surname = reader.ReadString();
        Phone_nr = reader.ReadInt32();
        client.Add(new Client(ID_client, Name, Surname, Phone_nr));
      }
    }
    foreach (Client clients in client){
      Console.WriteLine($"ID: {clients.ID_client}  Name: {clients.Name}, Surname: {clients.Surname}, Phone_nr: {clients.Phone_nr}");
      Console.WriteLine("Press any key to continue!");
      Console.ReadKey();
    }
  }
}