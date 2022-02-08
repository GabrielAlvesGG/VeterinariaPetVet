using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petVet.Models
{
    public class Cliente
    {
        public int id{get;set;}
        public string nome {get;set;}

        public DateTime dataNascimento {get;set;}
        public string login {get;set;}
        public string senha {get;set;}
    }
}