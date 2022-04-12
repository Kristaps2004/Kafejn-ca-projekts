using System;

class Program {

  static int Izvele(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
  }
  
  static void Main(){
    Console.Clear();
    Console.WriteLine(@"
===================================================
        KAFEINICAS PARVALDIBAS SISTEMA
===================================================

Main Menu:
- 1 - Add data
- 2 - View data
- 3 - Delete data
- 4 - Search data
- 5 - Summary
- 6 - Sort
- 7 - Exit
____________________________________________________");
    Console.Write("Enter Your choice: ");
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
      case 1:
        Menu2();
          break;
      case 2:
        Menu2();
          break;
      case 3:
        Menu2();
          break;
      case 4:
        Menu2();
          break;
      case 5:
        Menu2();
          break;
      case 6:
        Menu2();
          break;
      case 7:
        Environment.Exit(0);
          break;
      default:
          success = false;
          Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
          Console.WriteLine("                                                    ");
          Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
          Console.Write("Choice not in range! Enter Your choice: ");
					break;
      }
    }
  }
  
  static void Menu2(){
    Console.Clear();
    Console.WriteLine(@"
===================================================
        KAFEINICAS PARVALDIBAS SISTEMA
===================================================

Add Data Menu:
- 1 - Client
- 2 - Menu
- 3 - Order
- 4 - Back

____________________________________________________");
    Console.Write("Enter Your choice: ");
    bool success = false;
    while (!success){
      success = true;
      switch(Izvele()){
        case 1:
          Main();
            break;
        case 2:
          Main();
            break;
        case 3:
          Main();
            break;
        case 4:
          Main();
            break;
        default:
          success = false;
          Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
          Console.WriteLine("                                                    ");
          Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
          Console.Write("Choice not in range! Enter Your choice: ");
					break;
      }
    }
  }
}