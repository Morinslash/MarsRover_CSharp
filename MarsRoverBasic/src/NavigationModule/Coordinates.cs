namespace MarsRoverBasic.NavigationModule;

public record Coordinates
{
    public Coordinates()
    {
    }

    public Coordinates(int latitude, int longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public int Latitude { get; init; }

    public int Longitude { get; init; }

}