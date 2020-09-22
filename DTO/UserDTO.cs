
namespace DesafioMutant.API.Models
{
    public class UserDTO
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public AddressDTO address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public CompanyDTO company { get; set; }

        public UserDTO() { }
    }

    public class AddressDTO
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public GeolocationDTO geo { get; set; }

        public AddressDTO() { }
    }

    public class GeolocationDTO
    {
        public string lat { get; set; }
        public string lng { get; set; }

        public GeolocationDTO() { }
    }

    public class CompanyDTO
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }

        public CompanyDTO() { }
    }
}
