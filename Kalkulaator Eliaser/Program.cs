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


