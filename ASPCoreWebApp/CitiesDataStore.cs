
using ASPCoreWebApp.Models;
using CityInfo.API.Models;

namespace Cityinfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> cities { get; set; }

        public CitiesDataStore()
        {
            cities = new List<CityDTO>()
            {
                new CityDto()
            {
                Id =1,
                Name= "New York",
                Description="The one with the big park"

            },
            new CityDto()
            {
                 Id = 2,
                 Name ="AntWrep",
                 Description = "The one with the big Tower"

            },
            new CityDto()
            {
                 Id = 3,
                 Name = "Paris",
                 Description = "The one with the big Theater"

            },

            
            

        }
    }
}
