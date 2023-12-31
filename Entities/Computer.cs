﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities
{
    public class Computer : IEntity
    {
        public int ComputerId { get; set; }
        public string? ComputerName { get; set; }
        public string? ComputerModel { get; set; }
        public string? GraphicsCard { get; set; }

        public string? OperatingSystem { get; set; }

        public string? Ram { get; set; }
        public int ScreenSize { get; set; }


    }
}
