namespace Catel.Benchmarks.Fixtures
{
    using Catel.Data;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PersonModel : ModelBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }

    public class PersonRegularModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
