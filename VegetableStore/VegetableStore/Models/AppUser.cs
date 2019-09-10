using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using VegetableStore.Models.Enums;

namespace VegetableStore.Models
{
    [Table("AppUsers")]
    public class AppUser: IdentityUser<Guid>
    {
        public AppUser()
        {
        }

        public AppUser(Guid id, string fullName, string userName,
            string email, string phoneNumber, string address, Status status)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Status = status;
        }

        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Address { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}