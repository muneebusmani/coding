public class Program
{
    public static void Main()
    {
        Astrology Astrology = new Astrology();
        Astrology.run();
    }
}
class Astrology
{
    int date;
    int length;
    bool status;
    string month;
    string message;
    string ZodiacSign = "Zodiac Sign: ";
    string Element = "Element: ";
    string RulingPlanet = "Ruline Planet: ";
    string PersonalityTraits = "Personality Traits: ";
    string compatibility = "Compatibility: ";
    public static void Print(string args)
    {
        Console.WriteLine(args);
    }
    public void run()
    {


        Console.WriteLine("Enter Your Date of Month:");
        status = int.TryParse(Console.ReadLine(), out date);
        length = date.ToString().Length;
        Console.Clear();

        Console.WriteLine("Enter Your Birth Month" +
            "\neg:" +
            "\njanuary" +
            "\njan" +
            "\n01" +
            "\n1");
        month = (Console.ReadLine()).ToLower();
        Console.Clear();
        if (!status | length > 2 | length == 0)
        {
            Print("Please Put Date in Correct format");
            Thread.Sleep(1000);
            Console.Clear();
            Program.Main();
        }
        switch (month)
        {
            case "january":
            case "jan":
            case "01":
            case "1":
                ZodiacSign += (date >= 20) ? "Aquarius (January 20 - February 18)" : "Capricorn (December 22 - January 19)";
                Element += (date >= 20) ? "Air" : "Earth";
                RulingPlanet += (date >= 20) ? "Uranus" : "Saturn";
                PersonalityTraits += (date >= 20) ? "Innovative, open-minded, and value intellectual pursuits. Often seen as unconventional." : "Disciplined, responsible, and goal-oriented. Often seen as wise and mature.";
                compatibility += (date >= 20) ? "Best with Gemini and Libra, good with Aries and Sagittarius, challenging with Taurus and Scorpio." : "Best with Taurus and Virgo, good with Scorpio and Pisces, challenging with Aries and Libra.";
                break;

            case "february":
            case "feb":
            case "02":
            case "2":
                ZodiacSign += (date >= 19) ? "Pisces (February 19 - March 20)" : "Aquarius (January 20 - February 18)";
                Element += (date >= 19) ? "Water" : "Air";
                RulingPlanet += (date >= 19) ? "Neptune" : "Uranus";
                PersonalityTraits += (date >= 19) ? "Compassionate, imaginative, and sensitive. Often in tune with emotions and creative." : "Innovative, open-minded, and value intellectual pursuits. Often seen as unconventional.";
                compatibility += (date >= 19) ? "Best with Cancer and Scorpio, good with Taurus and Capricorn, challenging with Gemini and Sagittarius." : "Best with Gemini and Libra, good with Aries and Sagittarius, challenging with Taurus and Scorpio.";
                break;

            case "march":
            case "mar":
            case "03":
            case "3":
                ZodiacSign += (date >= 21) ? "Aries (March 21 - April 19)" : "Pisces (February 19 - March 20)";
                Element += (date >= 21) ? "Fire" : "Water";
                RulingPlanet += (date >= 21) ? "Mars" : "Neptune";
                PersonalityTraits += (date >= 21) ? "Adventurous, confident, and competitive. Natural leaders with a tendency towards impulsiveness and ambition." : "Compassionate, imaginative, and sensitive. Often in tune with emotions and creative.";
                compatibility += (date >= 21) ? "Best with Leo and Sagittarius, good with Gemini and Aquarius, challenging with Cancer and Capricorn." : "Best with Cancer and Scorpio, good with Taurus and Capricorn, challenging with Gemini and Sagittarius.";
                break;

            case "april":
            case "apr":
            case "04":
            case "4":
                ZodiacSign += (date >= 20) ? "Taurus (April 20 - May 20)" : "Aries (March 21 - April 19)";
                Element += (date >= 20) ? "Earth" : "Fire";
                RulingPlanet += (date >= 20) ? "Venus" : "Mars";
                PersonalityTraits += (date >= 20) ? "Reliable, practical, and grounded. Appreciate stability and are known for determination and stubbornness." : "Adventurous, confident, and competitive. Natural leaders with a tendency towards impulsiveness and ambition.";
                compatibility += (date >= 20) ? "Best with Virgo and Capricorn, good with Cancer and Pisces, challenging with Leo and Aquarius." : "Best with Leo and Sagittarius, good with Gemini and Libra, challenging with Taurus and Scorpio.";
                break;

            case "may":
            case "05":
            case "5":
                ZodiacSign += (date >= 21) ? "Gemini (May 21 - June 20)" : "Taurus (April 20 - May 20)";
                Element += (date >= 21) ? "Air" : "Earth";
                RulingPlanet += (date >= 21) ? "Mercury" : "Venus";
                PersonalityTraits += (date >= 21) ? "Adaptable, communicative, and curious. Display a dual nature and enjoy intellectual pursuits." : "Reliable, practical, and grounded. Appreciate stability and are known for determination and stubbornness.";
                compatibility += (date >= 21) ? "Best with Libra and Aquarius, good with Aries and Leo, challenging with Virgo and Pisces." : "Best with Virgo and Capricorn, good with Cancer and Pisces, challenging with Leo and Aquarius.";
                break;

            case "june":
            case "jun":
            case "06":
            case "6":
                ZodiacSign += (date >= 21) ? "Cancer (June 21 - July 22)" : "Gemini (May 21 - June 20)";
                Element += (date >= 21) ? "Water" : "Air";
                RulingPlanet += (date >= 21) ? "Moon" : "Mercury";
                PersonalityTraits += (date >= 21) ? "Emotional, nurturing, and family-oriented. Highly intuitive and protective of loved ones." : "Adaptable, communicative, and curious. Display a dual nature and enjoy intellectual pursuits.";
                compatibility += (date >= 21) ? "Best with Scorpio and Pisces, good with Taurus and Virgo, challenging with Aries and Libra." : "Best with Virgo and Capricorn, good with Cancer and Pisces, challenging with Leo and Aquarius.";
                break;

            case "july":
            case "jul":
            case "07":
            case "7":
                ZodiacSign += (date >= 23) ? "Leo (July 23 - August 22)" : "Cancer (June 21 - July 22)";
                Element += (date >= 23) ? "Fire" : "Water";
                RulingPlanet += (date >= 23) ? "Sun" : "Moon";
                PersonalityTraits += (date >= 23) ? "Confident, charismatic, and love the spotlight. Strong sense of pride and enjoy creative pursuits." : "Emotional, nurturing, and family-oriented. Highly intuitive and protective of loved ones.";
                compatibility += (date >= 23) ? "Best with Aries and Sagittarius, good with Gemini and Libra, challenging with Taurus and Scorpio." : "Best with Scorpio and Pisces, good with Taurus and Virgo, challenging with Aries and Libra.";
                break;

            case "august":
            case "aug":
            case "08":
            case "8":
                ZodiacSign += (date >= 23) ? "Virgo (August 23 - September 22)" : "Leo (July 23 - August 22)";
                Element += (date >= 23) ? "Earth" : "Fire";
                RulingPlanet += (date >= 23) ? "Mercury" : "Sun";
                PersonalityTraits += (date >= 23) ? "Detail-oriented, practical, and analytical. Strong work ethic and known for cleanliness and organization." : "Confident, charismatic, and love the spotlight. Strong sense of pride and enjoy creative pursuits.";
                compatibility += (date >= 23) ? "Best with Taurus and Capricorn, good with Cancer and Scorpio, challenging with Gemini and Sagittarius." : "Best with Aries and Sagittarius, good with Gemini and Libra, challenging with Taurus and Scorpio.";
                break;

            case "september":
            case "sep":
            case "09":
            case "9":
                ZodiacSign += (date >= 23) ? "Libra (September 23 - October 22)" : "Virgo (August 23 - September 22)";
                Element += (date >= 23) ? "Air" : "Earth";
                RulingPlanet += (date >= 23) ? "Venus" : "Mercury";
                PersonalityTraits += (date >= 23) ? "Diplomatic, charming, and seek balance and harmony. Keen sense of justice." : "Detail-oriented, practical, and analytical. Strong work ethic and known for cleanliness and organization.";
                compatibility += (date >= 23) ? "Best with Gemini and Aquarius, good with Leo and Sagittarius, challenging with Cancer and Capricorn." : "Best with Taurus and Capricorn, good with Cancer and Scorpio, challenging with Gemini and Sagittarius.";
                break;

            case "october":
            case "oct":
            case "10":
                ZodiacSign += (date >= 23) ? "Scorpio (October 23 - November 21)" : "Libra (September 23 - October 22)";
                Element += (date >= 23) ? "Water" : "Air";
                RulingPlanet += (date >= 23) ? "Pluto" : "Venus";
                PersonalityTraits += (date >= 23) ? "Intense, passionate, and determined. Strong willpower and ability to keep secrets." : "Diplomatic, charming, and seek balance and harmony. Keen sense of justice.";
                compatibility += (date >= 23) ? "Best with Cancer and Pisces, good with Virgo and Capricorn, challenging with Leo and Aquarius." : "Best with Gemini and Aquarius, good with Leo and Sagittarius, challenging with Cancer and Capricorn.";
                break;

            case "november":
            case "nov":
            case "11":
                ZodiacSign += (date >= 22) ? "Sagittarius (November 22 - December 21)" : "Scorpio (October 23 - November 21)";
                Element += (date >= 22) ? "Fire" : "Water";
                RulingPlanet += (date >= 22) ? "Jupiter" : "Pluto (Mars, traditionally)";
                PersonalityTraits += (date >= 22) ? "Adventurous, optimistic, and love exploration. Free-spirited nature." : "Intense, passionate, and determined. Strong willpower and ability to keep secrets.";
                compatibility += (date >= 22) ? "Best with Aries and Leo, good with Gemini and Aquarius, challenging with Virgo and Pisces." : "Best with Cancer and Pisces, good with Virgo and Capricorn, challenging with Leo and Aquarius.";
                break;

            case "december":
            case "dec":
            case "12":
                ZodiacSign += (date >= 22) ? "Capricorn (December 22 - January 19)" : "Sagittarius (November 22 - December 21)";
                Element += (date >= 22) ? "Earth" : "Fire";
                RulingPlanet += (date >= 22) ? "Saturn" : "Jupiter";
                PersonalityTraits += (date >= 22) ? "Disciplined, responsible, and goal-oriented. Often seen as wise and mature." : "Adventurous, optimistic, and love exploration. Free-spirited nature.";
                compatibility += (date >= 22) ? "Best with Taurus and Virgo, good with Scorpio and Pisces, challenging with Aries and Libra." : "Best with Aries and Leo, good with Gemini and Aquarius, challenging with Virgo and Pisces.";
                break;
            default:
                message = "Incorrect Month or Incorrect Date Given";
                Print(message);
                Thread.Sleep(1000);
                Console.Clear();
                Program.Main();
                break;
        }
        message =
            $"{ZodiacSign}\n" +
            $"{Element}\n" +
            $"{RulingPlanet}\n" +
            $"{PersonalityTraits}\n" +
            $"{compatibility}";
        Print(message);
        Console.ReadKey();
    }
}