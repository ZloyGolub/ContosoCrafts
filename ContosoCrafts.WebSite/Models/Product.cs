using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("Maker")]
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        [JsonPropertyName("Url")]
        public string Url { get; set; }
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
        [JsonPropertyName("Ratings")]
        public int[] Ratings { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        //The same as line up here
        //public override string ToString()
        //{
        //    return JsonSerializer.Serialize<Product>(this);
        //}


    }
}
