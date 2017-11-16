﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEncuestas.Models.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
