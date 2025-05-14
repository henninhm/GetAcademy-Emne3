// See https://aka.ms/new-console-template for more information

//1. Converter
// Lag et program som kan konvertere valuta, temperatur eller vekt
// Du skal kunne få alternativer for hva du vil konvertere,
// velge hva du vil konvertere til, og så skrive inn en verdi før
// du får svar i konsollen.



class Converter
{
    static void Main(string[] args)
    {
        Start();
    }

    public static double Convert(double fra, double ratio)
    {
        double result = fra * ratio;
        return result;
    }

    public static void Valuta()
    {
        Console.WriteLine("Hvilken valuta vil du konvertere fra? dollar, euro, pund");
        string inputValutaFra = Console.ReadLine();
        Console.WriteLine("Hvilken valuta vil du konvertere til? dollar, euro, pund");
        string inputValutaTil = Console.ReadLine();
        string sInput = "";
        double inputVerdi = 0;
        double ratio = 0;
        double resultat = 0;

        if (inputValutaFra == "euro")
        {
            if (inputValutaTil == "dollar")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 1 / 0.88974;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} euro er lik {resultat} dollar.");
            }
            else if (inputValutaTil == "pund")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 0.84238;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} euro er lik {resultat} pund.");
            }
        }
        else if (inputValutaFra == "dollar")
        {
            if (inputValutaTil == "euro")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 0.88974;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} dollar er lik {resultat} euro.");
            }
            else if (inputValutaTil == "pund")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 0.74933;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} dollar er lik {resultat} pund.");
            }
        }
        else if (inputValutaFra == "pund")
        {
            if (inputValutaTil == "euro")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 1 / 0.84238;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} pund er lik {resultat} euro.");
            }
            else if (inputValutaTil == "dollar")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 1 / 0.74933;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} pund er lik {resultat} dollar.");
            }
        }
    }

    public static void Temperatur()
    {
        Console.WriteLine("Hvilken temperatur vil du konvertere fra? farenheight, celvin eller celsius");
        string inputTemperaturFra = Console.ReadLine();
        Console.WriteLine("Hvilken temperatur vil du konvertere til? farenheight, celvin eller celsius");
        string inputTemperaturTil = Console.ReadLine();
        double input = 0;
        string sInput = "";
        double resultat = 0;
        
        if (inputTemperaturFra == "farenheight")
        {
            if (inputTemperaturTil == "celvin")
            {
                Console.WriteLine("Hvilken temperatur vil du konvertere?");
                sInput = Console.ReadLine();
                input = Double.Parse(sInput);
                resultat = (input + 459.67) * 5 / 9;
                Console.WriteLine($"{input} fahrenheit er lik {resultat} kelvin.");
            }
            else if (inputTemperaturTil == "celsius")
            {
                Console.WriteLine("Hvilken temperatur vil du konvertere?");
                sInput = Console.ReadLine();
                input = Double.Parse(sInput);
                resultat = (input - 32) * 5 / 9;
                Console.WriteLine($"{input} fahrenheit er lik {resultat} celsius.");
            }
        }
        else if (inputTemperaturFra == "celvin")
        {
            if (inputTemperaturTil == "farenheight")
            {
                Console.WriteLine("Hvilken temperatur vil du konvertere?");
                sInput = Console.ReadLine();
                input = Double.Parse(sInput);
                resultat = input * 9 / 5 - 459.67;
                Console.WriteLine($"{input} kelvin er lik {resultat} fahrenheit.");
            }
            else if (inputTemperaturTil == "celsius")
            {
                Console.WriteLine("Hvilken temperatur vil du konvertere?");
                sInput = Console.ReadLine();
                input = Double.Parse(sInput);
                resultat = input - 273.15;
                Console.WriteLine($"{input} kelvin er lik {resultat} celsius.");
            }
        }
        else if (inputTemperaturFra == "celsius")
        {
            if (inputTemperaturTil == "farenheight")
            {
                Console.WriteLine("Hvilken temperatur vil du konvertere?");
                sInput = Console.ReadLine();
                input = Double.Parse(sInput);
                resultat = input * 9 / 5 + 32;
                Console.WriteLine($"{input} celsius er lik {resultat} fahrenheit.");
            }
            else if (inputTemperaturTil == "celvin")
            {
                Console.WriteLine("Hvilken temperatur vil du konvertere?");
                sInput = Console.ReadLine();
                input = Double.Parse(sInput);
                resultat = input + 273.15;
                Console.WriteLine($"{input} celsius er lik {resultat} kelvin.");
            }
        }
    }

    public static void Vekt()
    {
        Console.WriteLine("Hvilken vekt vil du konvertere fra? kilogram, pund,");
        string inputVektFra = Console.ReadLine();
        Console.WriteLine("Hvilken vekt vil du konvertere til? kilogram, pund,");
        string inputVektTil = Console.ReadLine();
        string sInput = "";
        double inputVerdi = 0;
        double ratio = 0;
        double resultat = 0;
        
        if (inputVektFra == "kilogram")
        {
            if (inputVektTil == "pund")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 2.2046;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} kilogram er lik {resultat} pund.");
            }
        }
        else if (inputVektFra == "pund")
        {
            if (inputVektTil == "kilogram")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                sInput = Console.ReadLine();
                inputVerdi = Double.Parse(sInput);
                ratio = 1 / 2.2046;
                resultat = Convert(inputVerdi, ratio);
                Console.WriteLine($"{inputVerdi} pund er lik {resultat} kilogram.");
            }
        }
        
    }

    public static void Start()
    {
        Console.WriteLine("Hva vil du konvertere? valuta, temperatur eller vekt?");
        string input = Console.ReadLine();
        
        if (input == "valuta")
        {
            Valuta();
        }
        else if (input == "temperatur")
        {
            Temperatur();
        }
        else if (input == "vekt")
        {
            Vekt();
        }
        else
        {
            Console.WriteLine("Ditt svar er ikke gyldig");
        }
        Start();
    }
    
}


