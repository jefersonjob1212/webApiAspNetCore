using System;
using System.Collections.Generic;

namespace webApiAspNetCore.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
