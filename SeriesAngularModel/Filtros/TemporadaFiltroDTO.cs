﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAngularModel.Filtros
{
    class TemporadaFiltroDTO
    {
        public int idserie { get; set; }

        public int nseason { get; set; }

        public Nullable<int> chapters { get; set; }

        public Nullable<int> year { get; set; }
    }
}
