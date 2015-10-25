﻿

using System;
using System.Linq;
using DataAccess.Contexts;
using Microsoft.AspNet.Identity;
using Models;
using TestMVVMLight.Model;
using ILogin = TestMVVMLight.ViewModel.ILogin;

namespace TestMVVMLight.Services
{
    public interface ILoginService : IDataService
    {
        PasswordVerificationResult? Login(ILogin volunteer);
    }

    public class LoginService : ILoginService
    {
        public PasswordVerificationResult? Login(ILogin volunteer)
        {
            using (var context = new Database())
            {
                var loginUser = context.Volunteers.First(v => v.Username == volunteer.Username);
                if (loginUser != null)
                {
                    return loginUser.VerifyPassword(volunteer.Password);
                }

                return null;
            }
        }

        public void GetData(Action<DataItem, Exception> callback)
        {
            throw new NotImplementedException();
        }
    }
}