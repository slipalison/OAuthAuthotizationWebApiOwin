﻿using System.Collections.Generic;

namespace OAuthAuthorizationWebApiOwin.SharedKernel.Interfaces
{
    public interface IRead<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
