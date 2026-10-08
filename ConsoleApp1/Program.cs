using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

int heroHp = 100;
int villainHp = 100;
int money = 600;
//spelaren kan välja namn
Console.WriteLine("Vad heter din hero?");
string heroName = Console.ReadLine();
Console.WriteLine("Vad heter din villain?");
string villainName = Console.ReadLine();


Console.WriteLine($"Du har {money} pengar.");
Console.WriteLine("På vem vill du satsa dina pengar på?");
Console.WriteLine($"1.{heroName}");
Console.WriteLine($"2.{villainName}");

string betChoice = Console.ReadLine();

Console.WriteLine("Hur mycket vill du satsa?");
string betS = Console.ReadLine();
int bet = 0;
int.TryParse(betS, out bet);

int round = 1;

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine($"----====Round{round}=====-----");
    Console.WriteLine($"{heroName}:{heroHp} {villainName}: {villainHp}");

    int heroDamage = Random.Shared.Next(14, 17);
    villainHp -= heroDamage;
    villainHp = Math.Max(0, villainHp);
    Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

    int villainDamage = Random.Shared.Next(20);
    heroHp -= villainDamage;
    heroHp = Math.Max(0, heroHp);
    Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

    Console.WriteLine("Tryck på ett valfri knapp för att fortsätta");
    Console.ReadKey();
    round++;
}

Console.WriteLine("-----{The Battle is now done}-----");

if (heroHp == 0 && villainHp == 0)

{
    Console.WriteLine("It was a tie and we got not winner!");
}
else if (heroHp == 0)
{
    Console.WriteLine($"{villainName} vann!");
}
else
{
    Console.WriteLine($"{heroName} vann!");
}

if (heroHp == 0 && villainHp == 0)
{
    Console.WriteLine("Du får tillbaka dina pengar");
}
else if (betChoice == "1" && heroHp > 0)
{
    money += bet;
    Console.WriteLine($"Du vann {bet} pengar!");
}
else if (betChoice == "2" && villainHp > 0)
{
     money += bet;
    Console.WriteLine($"Du vann {bet} pengar!");
}
else
{
    money-= bet;
    Console.WriteLine($"Du förlorade {bet} pengar!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();