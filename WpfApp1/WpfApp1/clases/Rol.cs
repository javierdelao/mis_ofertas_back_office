using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace clases.Clases
{
    class Rol
    {
        [JsonProperty("id")]
        private long id { get; set; }

        [JsonProperty("name")]
        private String name { get; set; }

        [JsonProperty("description")]
        private String description { get; set; }

        public Rol()
        {
        }

        public Rol(long id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
       
    }
}
