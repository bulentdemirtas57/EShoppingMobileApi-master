using MobileApp.Data.Models;
using System;
using System.Collections.Generic;

namespace MobileApp.Data.Repositories
{
    public interface IUserRepository
    {
        public List<TblUser> GetAllUsers();

        public TblUser GetUserById(int userId);

        public bool UpdateUserDateOfBirth(int userId, DateTime newBirthOfDate);

        public bool CheckEmail(string email);

        public TblUser Login(string email, string password);

        public void UpdateUserRefreshToken(int userId, string refreshToken, DateTime? refreshTokenEndDate);

        public TblUser GetUserByRefreshToken(string refreshToken);

        public TblUser Register(string firstName, string lastName, string phoneNumber, string email, string password);

    }
}
