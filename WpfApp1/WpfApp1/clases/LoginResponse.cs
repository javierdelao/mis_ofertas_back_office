using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace clases.Clases
{
     class LoginResponse
    {
        [JsonProperty("user")]
        public User user { get; set; }

        [JsonProperty("status")]
        public String status { get; set; }

        public LoginResponse()
        {
        }

      
    }

}
