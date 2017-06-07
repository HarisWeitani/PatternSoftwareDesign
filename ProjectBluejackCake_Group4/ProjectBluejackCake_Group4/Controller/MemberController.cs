using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Controller
{
    public class MemberController
    {
        public static bool checkEmail(String email)
        {
            if (email.Split('@').Length != 2) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") - 1) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") + 1) return false;
            return true;
        }
        public static Member insertMember(String name, String email, String password, DateTime dob, String phone, String address)
        {
            Member m = Factory.MemberFactory.create(name, email, password, dob, phone, address);
            return m;
        }
        public static Member login(String email, String password)
        {
            Member member = Handler.MemberHandler.login(email, password);
            return member;
        }   
    }
}