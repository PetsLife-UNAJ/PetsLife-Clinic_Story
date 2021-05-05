﻿using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Queries.Repository
{
    public interface ITurnoQueries
    {
       public List<ResponseTurno> GetAllByFecha(string fecha);
    }
}
