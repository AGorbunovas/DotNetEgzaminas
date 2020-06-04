using CreditCompanyApplication.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CreditCompanyApplication.Controller
{
    public class UserController
    {
        public User User { get; set; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("Vartotojas negali buti lygus null", nameof(user));
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if(formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                
                //TODO: ka daryti, jei vartotojas nebuvo nuskaitytas
            }
        }

    }
}
