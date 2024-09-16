// rakendus kusib kasutajal sisestada oma vanusse
// kui vanus on vaiksem KUI 13 siis konsool utleb et liiga noor kasutada Instagrami
// muul juhul: "Welcome to Instagram"

Console.WriteLine("Please enter your age");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heapist (kulukam), 13 - stack (saastab resursse)

// int on numbride jaoks,
// Int32 parsib saatud numbri stringi intiks votab rohkem aega aga votab vahem vahem malu
if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}

else //userage is below 13
{
    Console.WriteLine("You are too young to use Instagram");
}
