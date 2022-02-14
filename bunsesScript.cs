/*
BunsesScript, C# edition,
developed by, ClassicMC.
credits(); for more info.
*/
using System;

namespace bunsesScript
{
	public class Program
	{
		static void Main(string[] args)
    {
    	usingBunses();
    	//Main code
        
    }
    //bunsesScript functions
    static void printf(string bunses)
    {
        Console.WriteLine(bunses);
    }
    static void loop(string text, int start, int length)
    {
    	bool x = true;
        while(x)
        {
            start +=1;
            printf(text);
            if (start >= length)
            {
                x = false;
            }
        }
        
    }
    static void usingBunses()
    {
        //Imports bunsesScript
        printf("/Using bunsesScript 1.0.0\\");
    }
    static void credits()
    {
        printf("Made by, ClassicMC");
        printf("v1.0.0 c# edition");
        printf("helpf() for more.");
        printf("Semicolons are required,");
        printf("Bunses is based on \"prototype e-sharp\" for game delopment.");
    }
    static void helpf()
    {
        printf("to print items print(\"//print stuff\");");
        printf("to loop loop(\"//loop text\",true,//startingAmount,//endingAmount\")");
        printf("\\n for a new line, \\\", and \\\', \\\\ for avoding those symbols in strings");
        printf("If you are experincing errors,double check that your code has semicolons \";\"");
    }
    static void inputf(string expected,string said)
    {
      string userInput = Console.ReadLine();
      if(userInput == expected){
        printf(said);
      }
    }

	}
}