﻿using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Member
    {
        public string Name { get; set; }

        public List<MemberType> MemberTypes { get; set; }

        public string MaterialDescription { get; set; }

        public MaterialType MaterialType { get; set; }

        public Guid MaterialGuid { get; set; }

        public bool FieldInstalled { get; set; }

        public double StockLength { get; set; }

        public Geometry Geometry { get; set; }

        public Vector3D Orientation { get; set; }
    }
}
