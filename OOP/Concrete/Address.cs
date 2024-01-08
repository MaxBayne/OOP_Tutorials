namespace OOP.Models
{
    public class Address
    {
        public Address() { }
        public Address(string country,string city,string street,string building)
        {
            CountryName=country;
            CityName=city;
            StreetNo=street;
            BuildingNo=building;
        }

        #region Encapsulation

        public string StreetNo { get; private set; }
        public string CityName { get; private set; }
        public string CountryName { get; private set; }
        public string BuildingNo { get; private set; }


        public void ChangeCountry(string country)
        {
            CountryName = country;
        }
        public void ChangeCity(string city)
        {
            CityName = city;
        }
        public void ChangeStreet(string street)
        {
            StreetNo = street;
        }
        public void changeBuilding(string building)
        {
            BuildingNo = building;
        }

        #endregion
    }
}
