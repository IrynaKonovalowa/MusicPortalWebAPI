﻿using System.Collections.Generic;
using System;

namespace MusicPortalWebAPI.Repositories
{
    public interface IRepository<T> where T : class 
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Get(string name);
        Task Create(T item);
        void Update(T item);
        Task Delete(int id);
        Task Save();
    }
}
