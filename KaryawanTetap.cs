﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPP_2695
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
