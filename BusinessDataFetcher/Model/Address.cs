using System;

namespace BusinessDataFetcher
{
    namespace Model
    {
        public class Address
        {
            public string City;
            public string Street;
            public string Wojewodztwo;

            public Address(string woj, string city, string street)
            {
                this.Wojewodztwo = woj;
                this.City = city;
                this.Street = street;
            }

            public static Address FromString(string html)
            {
                string[] x = html.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                string woj = x[0].Trim();
                string city = string.Empty;
                string street = string.Empty;
                if (x.Length > 1)
                    city = x[1].Trim();
                if (x.Length > 2)
                {
                    street = x[2].Trim();
                }
                return new Address(woj, city, street);
            }

            public string SeparateBy(string separator)
            {
                string[] add = new string[] { Wojewodztwo, City, Street };
                return string.Join(separator, add);
            }

            public override string ToString()
            {
                return this.Wojewodztwo + " " + this.City + " " + this.Street;
            }
        }
    }
}