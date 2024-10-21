public abstract class GeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual string Information()
    {
        return $"Назва: {Name}\nКоординати:{X},{Y} \n Опис:{Description}";
    }
}

public class River : GeographicObject
{
    public string Speed { get; set; }
    public string Length { get; set; }

    public override string Information()
    {
        return $"{base.Information()}\n Швидкiсть:{Speed}\nДовжина:{Length}";
    }

}

public class Mountain : GeographicObject
{
    public double Altitude { get; set; }
    public override string Information()
    {
        return $"{base.Information()}\nВисота:{Altitude}";
    }
}

class Progrom
{
    static void Main(string[] args)
    {
        River river = new River
        {
            X = 29.11,
            Y = 50.44,
            Name = "iрпiнь",
            Description = "права притока Днiпра",
            Speed = "15km/год",
            Length = "163км"

        };
        Mountain mountain = new Mountain
        {
            X = 12.34,
            Y = 56.78,
            Name = "Говерла",
            Description = "Найвища гора в Українi",
            Altitude = 2061
        };

        Console.WriteLine(river.Information());
        Console.WriteLine(mountain.Information());
    }
}