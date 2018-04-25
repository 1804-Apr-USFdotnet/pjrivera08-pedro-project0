 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Deserialize
    {
        public static Restaurant FromJson(string json) => JsonConvert.DeserializeObject<Restaurant>(json, Converter.Settings);
    }
}

