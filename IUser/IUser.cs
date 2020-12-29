using System;
using System.Collections.Generic;

namespace IModel
{
    public interface IUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Pw { get; set; }
        public List<@int> characters{get;}
    }
}
