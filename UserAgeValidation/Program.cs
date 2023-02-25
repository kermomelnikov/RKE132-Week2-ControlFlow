// rakendus küsib kasutajal valida tema sugu (m/f)
// rakendus küsib kasutaja perekonnanime sisetada
// lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); // loeb konsoolist maha andmeid string ehk sõne formaadis

Console.WriteLine("Please, enter your lastname:");

string userName = Console.ReadLine();

if(userGender == 'm')
 {
    Console.WriteLine($"Welcome, Mr. {userName}!");
 }
else if(userGender == 'f') 
{
    Console.WriteLine($"Welcome, Ms. {userName}!");
}
else 
{
    Console.WriteLine($"Welcome {userName}!");
}