﻿using MikroServisProizvod.Application.BaseDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MikroServisProizvod.Application.DefaultServices
{
    public interface IAddService<T>
        where T : BaseDto
    {
        T Add(T dto);
    }
}