﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Conctete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}