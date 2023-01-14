﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Interfaces
{
    public interface IListingsAPI
    {
        Task<object> GetList();
        Task<object> GetListByTotalPrice(int numPassenger);
    }
}
