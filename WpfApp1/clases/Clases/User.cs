using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Clases
{
    class User
    {
        private long id;

        private String rut;

        private String firstName;

        private String lastName;

        private String password;

        private String email;

        private Rol rol;

        public User()
        {
        }

     
        public long getId()
        {
            return id;
        }

 
        public void setId(long id)
        {
            this.id = id;
        }

        public String getRut()
        {
            return rut;
        }

        public void setRut(String rut)
        {
            this.rut = rut;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public Rol getRol()
        {
            return rol;
        }

        public void setRol(Rol rol)
        {
            this.rol = rol;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }



    }
}
