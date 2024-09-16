// rakendus kusib kasutajal sisestada oma vanusse
// kui vanus on vaiksem KUI 13 siis konsool utleb et liiga noor kasutada Instagrami
// muul juhul: "Welcome to Instagram"

Console.WriteLine("Please enter your age");

string UserAge = Console.ReadLine();

int UserAgeNum = 0;
// boolean on kaks vaartust, true voi false
bool isAgeNumber = Int32.TryParse(UserAge, out UserAgeNum);
//kui bool sisestakse inti, ehk numbri tuleb v
Console.WriteLine($"Parse result {isAgeNumber}. User is {UserAgeNum} years old.");
if (isAgeNumber == true)
{
    if (UserAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too youn to use Instagram");
    }
}   
else
{
    Console.WriteLine("Could not process your age");
}