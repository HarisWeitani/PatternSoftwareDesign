﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBluejackCake_Group4.Handler
{
    public class MemberHandler
    {
        public static Member login(String email , String password)
        {
            Member member = MemberRepositories.LoginUser(email, password);
            return member;
        }
    }
}