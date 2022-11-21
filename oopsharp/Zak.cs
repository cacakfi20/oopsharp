namespace oopsharp;

internal class Zak
{
    public string Jmeno;
    public string Prijmeni;
    public int RokNarozeni;

    
    public Zak() {}
    public Zak(string _jmeno, string _prijmeni)
    {
        Jmeno = _jmeno;
        Prijmeni = _prijmeni;
        RokNarozeni = -1;
    }
    public Zak(string _jmeno, string _prijmeni, int _rokNarozeni)
    {
        Jmeno = _jmeno;
        Prijmeni = _prijmeni;
        RokNarozeni = _rokNarozeni;
    }

    private int VratVek()
    {
        return 2022 - RokNarozeni;
    }

    public void VypisVek()
    {
        Console.WriteLine("Je mi: " + VratVek().ToString() + " let");
    }

    public void Pozdrav()
    {
        Console.WriteLine("Ahoj, já jsem " + Jmeno);
    }
}