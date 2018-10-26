﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Models.ApiViewModels
{
    public class BaseApiModel<T>
    {
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}
