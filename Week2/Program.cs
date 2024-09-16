//rakendus küsib kasutajalt sugu
//rakendus küsib kasutajalt perekonna nime
//lähtudes vastusest: "Welcome, Mr. [perekonna nimi] / Welcome, Mrs. [perekonna nimi]

Console.WriteLine("Please select you gender, (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist sisestatud andmeid stringina
Console.WriteLine("Please enter your last name");
string userName = Console.ReadLine();
if(userGender == 'm')
{
    Console.WriteLine($"Hello Mr. {userName}!");
}
else if(userGender == 'f')
{ 
    Console.WriteLine($"Hello Mrs. {userName}!"); 
}
else
{
    Console.WriteLine($"Welcome, {userName}!");
}