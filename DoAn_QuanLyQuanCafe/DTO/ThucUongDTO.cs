﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCafe.DTO
{
    public class ThucUongDTO
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }

        public ThucUongDTO(string name, double value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }

    }
}
