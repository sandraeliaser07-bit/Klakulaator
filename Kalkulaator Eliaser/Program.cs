using System.ComponentModel.Design;

int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Sisesta arv 1");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sisesta arv 2");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Millist tehet soovite teha? + - / * ^");
string tehtetüüp = Console.ReadLine();
float tulemus = 0;
if (tehtetüüp == "+")
{
    tulemus = arv1 + arv2;
}
if (tehtetüüp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetüüp == "/")
{
    tulemus = arv1 / arv2;

}
if (tehtetüüp == "*")
{
    tulemus = arv1 * arv2;

}
if (tehtetüüp == "^")
{
    tulemus = (float)Math.Pow(arv1, arv2);
}
Console.WriteLine(tulemus);
string lemmikpuuvili = "";
string valik = "";
string lemmikjuurvili ="";
Console.WriteLine("Kas sulle meeldivad puuviljad või juurviljad? Kirjuta juurviljad, 0 kui kui puuvili, 1 kui juurvili");
valik = Console.ReadLine();
if (valik == "puuviljad")
{
    lemmikpuuvili = Console.ReadLine();
    if (lemmikpuuvili == "maasikas")
    {
        Console.WriteLine("Maasikas ei ole puuvili");
    }
    else if (lemmikpuuvili == "pirn")
    {
        Console.WriteLine("Kas hapu pirn või magus pirn, mõlemad on head");
    }
    else if (lemmikpuuvili == "kartul")
    {
        Console.WriteLine("See ei kasva isegi puu otsas");
    }
    else
    {
        Console.WriteLine("Ei tunne seda puuvilja");
    }
}
else if (valik == ("juurviljad"))
{
    lemmikjuurvili = Console.ReadLine();
    if (lemmikjuurvili == "tomat")
    {
        Console.WriteLine("Tomat ei ole teoreetiliselt juurvili");
    }
}
else if (lemmikjuurvili == "kurk")
{
    Console.WriteLine("Hapukurk või tavaline?");
}
else
{
     Console.WriteLine("Ei tunne seda juurvilja");
}