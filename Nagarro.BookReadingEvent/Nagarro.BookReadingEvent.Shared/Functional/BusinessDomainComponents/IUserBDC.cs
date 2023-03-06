﻿using System.Collections.Generic;

namespace Nagarro.BookReadingEvent.Shared
{
    public interface IUserBDC : IBusinessDomainComponent
    {
        OperationResult<UserDTO> RegisterUser(UserDTO UserDTO);
        List<UserDTO> GetAllUsers();
        UserDTO GetUserById(int UserId);
        UserDTO GetUserByEmailAndPassword(string Email, string Password);
    }
}
