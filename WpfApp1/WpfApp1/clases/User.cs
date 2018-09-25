using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace clases.Clases
{
    class User
    {
        [JsonProperty("id")]
        private long id { get; set; }

        [JsonProperty("rut")]
        private String rut { get; set; }

        [JsonProperty("firstName")]
        private String firstName { get; set; }

        [JsonProperty("lastName")]
        private String lastName { get; set; }

        [JsonProperty("password")]
        private String password { get; set; }

        [JsonProperty("email")]
        private String email { get; set; }

        [JsonProperty("rol")]
        private Rol rol { get; set; }

        public User()
        {
        }

    }
}
