using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
    	try{
        	char ans='y';
      float first, second, result;
      int choice;
      Console.WriteLine("Hello there."); 
      while(ans=='Y' || ans == 'y')
      {
      	Console.WriteLine("Enter First Number: ");
        first = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        second = float.Parse(Console.ReadLine());
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Add\n2. Subtract\n3. Division\n4. Multiply");
        choice = int.Parse(Console.ReadLine());
        if(choice==1){
        	result=first+second;
            Console.WriteLine("Result is: " + Convert.ToString(result));
            Console.WriteLine("\nDo you want to continue(Y/N)?");
            ans=char.Parse(Console.ReadLine());
        }
        else if(choice==2){
        	result=first-second;
            Console.WriteLine("Result is: " + Convert.ToString(result));
            Console.WriteLine("Do you want to continue(Y/N)?");
            ans=char.Parse(Console.ReadLine());
        }
        else if(choice==3){
        	result=first/second;
            Console.WriteLine("Result is: " + Convert.ToString(result));
            Console.WriteLine("Do you want to continue(Y/N)?");
            ans=char.Parse(Console.ReadLine());
        }
        else if(choice==4){
        	result=first*second;
            Console.WriteLine("Result is: " + Convert.ToString(result));
            Console.WriteLine("Do you want to continue(Y/N)?");
            ans=char.Parse(Console.ReadLine());
        }
        else{
            Console.WriteLine("Enter a valid choice");
            ans='y';
        }
        
      }
      if(ans=='N' || ans=='n')
        Console.WriteLine("--------------Thank You----------");
     }
     catch (Exception ex)
	 {
        	Console.WriteLine("ERROR OCCURED");
	 }
      
    }
  }
}
