﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IController<T>
    {
        void Create(T entity);
        T Get(int id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
