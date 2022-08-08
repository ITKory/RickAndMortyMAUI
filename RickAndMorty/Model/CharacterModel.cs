/* Необъединенное слияние из проекта "RickAndMorty (net6.0-windows10.0.19041.0)"
До:
using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
После:
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Json;
using System.Text.Json.Serialization;
*/

/*Необъединенное слияние из проекта "RickAndMorty (net6.0-maccatalyst)"
До:
using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
После:
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Json;
using System.Text.Json.Serialization;
*/

using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace RickAndMorty.Model
{


    public partial class CharacterModel
    {
        [JsonProperty("results")]
        public List<Character> Characters { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("pages")]
        public long Pages { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("prev")]
        public object Prev { get; set; }
    }
    public partial class Character
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("origin")]
        public Location Origin { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("episode")]
        public List<Uri> Episode { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }



}

