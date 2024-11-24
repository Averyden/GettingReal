﻿using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status CurrentStatus {  get; set; }
    }
}
