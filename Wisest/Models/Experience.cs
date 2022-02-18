﻿using System;
namespace Wisest.Models
{
    public class Experience
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Experience(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
