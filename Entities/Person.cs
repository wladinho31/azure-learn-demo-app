using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
