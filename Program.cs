//Coded by: Ulises Ortega
//Date Revised:09.08.22
//Project Name: Greater Than or Less Than
/*Description:
The program will ask the user to enter 2 numbers for evaluation,
The program will validate that a number is entered or return a message asking the user for a number 
variable and then compare then and output if Greater or Less Than or equal
that will complete the program and ask teh user to run the program again, Yes or No
*/
//Review By: Manuel Leyva, I like how the code is placed, evertything is nice and neat and has it own section for each part, the loop 
//works great, great job

Console.Clear();
string userChoice = "";

int num1, num2, result;
bool checkNum1, CheckNum2;

do{

do{
Console.WriteLine("Please Type the First Number");
checkNum1 = Int32.TryParse(Console.ReadLine(), out num1);
if (checkNum1 == false)
{
    Console.WriteLine("that is not a number, please enter a number");
}
}while(checkNum1 == false);


do{
Console.WriteLine("Please Type the Second Number");
//string n2 = Console.ReadLine();
checkNum1 = Int32.TryParse(Console.ReadLine(), out num2);
if (checkNum1 == false)
{
    Console.WriteLine("that is not a number, Please enter a number");
}
}while(checkNum1 == false);


if(num1>num2)
    {
    Console.WriteLine("");    
    Console.WriteLine("Numbers Evaluation");
    Console.WriteLine("");
    Console.WriteLine($"{num1} is greater than {num2}");
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"{num2} is less than {num1}");
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"{num1} is not equal to {num2}");
    Console.WriteLine("------------------------------------");
    }
if(num1<num2)
    {
    Console.WriteLine("");    
        
    Console.WriteLine("Numbers Evaluation");
    Console.WriteLine("");    
    Console.WriteLine($"{num1} is less than {num2}");
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"{num2} is greater than {num1}");
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"{num1} is not equal to {num2}");
    Console.WriteLine("------------------------------------");
    }
if(num1 == num2)
    {
    Console.WriteLine("");    
    Console.WriteLine("Numbers Evaluation");
    Console.WriteLine("");
    Console.WriteLine($"{num1} is not less than {num2}");
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"{num2} is not greater than {num1}");  
    Console.WriteLine("------------------------------------");  
    Console.WriteLine($"{num1} is equal to {num2}");
    Console.WriteLine("------------------------------------");
    }

do
{
    Console.WriteLine("Do you want to Run the program again Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "YES" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");