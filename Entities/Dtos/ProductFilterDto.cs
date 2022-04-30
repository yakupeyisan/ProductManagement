﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ProductFilterDto:IDto
    {
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int UnitTypeId { get; set; }
    }
}
