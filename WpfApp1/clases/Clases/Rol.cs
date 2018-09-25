using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Clases
{
    class Rol
    {

        private long id;

        private String name;

        private String description;

        public Rol()
        {
        }

        public Rol(long id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

       
        public long getId()
            {
                return id;
            }

        public void setId(long id)
            {
                this.id = id;
            }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }





    }
}
