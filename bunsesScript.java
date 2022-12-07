import java.util.Scanner;
/*
BunsesScript, Java edition,
developed by, ClassicMC.
credits(); for more info.
*/

public class Main {
    public static void main(String[] args) {
      usingBunses();
      //Main code
    }
    static void usingBunses(){
        //Imports bunses library
        System.out.println("/Using bunsesScript 1.0.1\\");
    }
    static void printf(String bunses){
        System.out.print(bunses);
    }
    static void loop(String text,Boolean x, int start, int length){
        while(x){
            start +=1;
            printf(text);
            if (start == length){
                x = false;
            }
        }
    }
    static void credits(){
        printf("\nMade by, ClassicMC");
        printf("\nv1.0.1 java edition");
        printf("\nhelpf() for more.");
        printf("\nSemicolons are required,");
        printf("\nBunses is based on \\\"prototype e-sharp\\\" for game delopment.");
    }
    static void helpf(){
        printf("\nto print items print(\"//print stuff\");");
        printf("\nto loop loop(\"//loop text\",true,//startingAmount,//endingAmount\")");
        printf("\n\\n for a new line, \\\", and \\\', \\\\ for avoding those symbols in strings");
        printf("\nto get user input inputf();");
        printf("\nIf you are experincing errors,double check that your code has semicolons \";\"");
    }
    static String inputf(){
        Scanner s1 = new Scanner(System.in);
        return s1.nextLine();
    }
}
