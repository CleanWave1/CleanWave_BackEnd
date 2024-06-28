namespace CleanWave_Backend.Profiles.Domain.Model.ValueObjects;

public record SpaceDetails(
    string PropertyType, 
    string CleaningType,
    string SpaceSize,
    int? NumberRooms,
    string FloorType,
    string Instructions)
{
    public SpaceDetails() : this(string.Empty, string.Empty, string.Empty,
        null, string.Empty, string.Empty)
    {
        
    }

    public SpaceDetails(string propertyType) : this(propertyType, string.Empty,
        string.Empty, null, string.Empty, string.Empty)
    {
        
    }
    public SpaceDetails(string propertyType, string cleaningType) : this(propertyType, cleaningType,
        string.Empty, null, string.Empty, string.Empty)
    {
        
    }
    public SpaceDetails(string propertyType, string cleaningType, string spaceSize) : this(propertyType, cleaningType,
        spaceSize, null, string.Empty, string.Empty)
    {
        
    }
    public SpaceDetails(string propertyType, string cleaningType, string spaceSize,
        int numberRooms) : this(propertyType, cleaningType,
        spaceSize, numberRooms, string.Empty, string.Empty)
    {
        
    }
    public SpaceDetails(string propertyType, string cleaningType, string spaceSize,
        int numberRooms, string floorType) : this(propertyType, cleaningType,
        spaceSize, numberRooms, floorType, string.Empty)
    {
        
    }
    public string FullSpaceDetails =>
        $"{PropertyType} {CleaningType} {SpaceSize} {NumberRooms} {FloorType} {Instructions}";
}