using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Factory
{
    public class MemberFactory
    {
        public static Member create(String name, String email, String password, DateTime dob, String phone, String address)
        {
            return new Member()
            {
                Name = name,
                Email = email,
                Password = password,
                DOB = dob,
                PhoneNumber = phone,
                Address = address,
                Type = "Customer"
            };
        }
    }
}