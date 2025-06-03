using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class DefaultData
    {
        public static List<UserInfo> GetDefaultUsers()
        {
            return new List<UserInfo>
            {
                new UserInfo
                {
                    Name = "Pavi",
                    Email = "pavi@gmail.com",
                    Password = "Pavi@1",
                    MobileNumber = "9789011226"
                },
                new UserInfo
                {
                    Name = "Ragu",
                    Email = "ragu@gmail.com",
                    Password = "Ragu@1",
                    MobileNumber = "9789011226"
                }
            };
        }

    }
}