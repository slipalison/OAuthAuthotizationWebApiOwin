﻿using OAuthAuthotizationWebApiOwin.SharedKernel.Interfaces;

namespace OAuthAuthotizationWebApiOwin.Domain.User.Interfaces
{
    public interface IUserRepository:IRead<User>,IWrite<User>
    {
    }
}