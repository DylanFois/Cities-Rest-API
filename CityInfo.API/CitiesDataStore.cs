using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id= 1,
                Name = "City 1",
                Description = "Description for City 1"
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id= 1,
                        Name = "POI1",
                        Description = "Description for POI 1"
                    },
                    new PointOfInterestDto()
                    {
                        Id= 2,
                        Name = "POI1",
                        Description = "Description for POI 1"
                    }
                }
            },
            new CityDto()
            {
                Id= 2,
                Name = "City 2",
                Description = "Description for City 2"
            },
            new CityDto()
            {
                Id= 3,
                Name = "City 3",
                Description = "Description for City 3"
            }
        };
        }
    }
}
