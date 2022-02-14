"""
Bunses, Python edition,,
developed by, ClassicMC.
credits(); for more info.
"""
def usingBunses():
    #Imports bunses
    x = 0;
def printf(bunses):
    print(bunses)
def loop(text, x, start,end):
    while x:
        start +=1;
        print(text);
        if start == end:
            x = False;
def credits():
    printf("Made by, ClassicMC")
    printf("v0.0.1 pythonEdition")
    printf("helpf() for more.")
    printf("Semicolons are not required,")
    printf("Bunses is based on \\\"prototype e-sharp\\\" for game delopment.")
def helpf():
    print("to print items printf(\"//print stuff\")");
    print("to loop loop(\"//loop text\",true,//startingAmount,//endingAmount\")");
    print("\\n for a new line, \\\", and \\\', \\\\ for avoding those symbols in strings");
    print("If you are experincing errors,double check that your code has no semicolons \";\"");
def inputf(expected,said):
    userInput = input()
    if userInput == expected:
        printf(said)
    else:
        printf("Nope")
#Initilize the bunses library        
usingBunses();        
#Main code loop 
