using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStore.Models;

namespace MedicalStore
{
    public class UserStateService
    {
         public List<UserInfo> Users { get; set; } = new List<UserInfo>
    {
        new UserInfo
        {
            UserID = "1",
            Name = "Pavi",
            Email = "pavi@gmail.com",
            Password = "123",
            MobileNumber = "1234567890",
            WalletBalance = "1000"
        },
        new UserInfo
        {
            UserID = "2",
            Name = "Ragu",
            Email = "ragu@gmail.com",
            Password = "123",
            MobileNumber = "0987654321",
            WalletBalance = "2000"
        }
        
    };

   
    public UserInfo? CurrentUser { get; set; }
    }
}