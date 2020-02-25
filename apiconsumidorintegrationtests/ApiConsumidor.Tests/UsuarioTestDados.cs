using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace ApiConsumidor.Tests
{
    public class Login
        {
           public string Usuario{get;set;}
           public string Senha{get;set;}
        }

    public static class UsuarioTestDados 
    {
        

        public static IEnumerable<object[]> FabricarCredenciaisCorretas =>
        new List<object[]>
        {
            new object[] {"cenario 001",200, new Login(){ Usuario="carlos21@gmail.com", Senha="123456"}},
            new object[] {"cenario 002",200, new Login(){ Usuario="carlos21@gmail.com", Senha="123457"}}
        };

    }
}