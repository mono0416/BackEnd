﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BackEnd.DTO;

namespace BackEnd.Servicio.Contrato
{
    public interface IDashboardServicio
    {
        DashboardDTO Resumen();
    }
}
