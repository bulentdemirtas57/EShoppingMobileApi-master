using MobileApp.Core;
using MobileApp.Data.Context;
using MobileApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileApp.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        MobileAppDbContext _db;

        public UserRepository(MobileAppDbContext db)
        {
            _db = db;
        }

        public List<TblUser> GetAllUsers()
        {
            return _db.TblUser.ToList();
        }

        public TblUser GetUserById(int userId)
        {
            return _db.TblUser.FirstOrDefault(p => p.IUserId == userId);
        }

        public bool UpdateUserDateOfBirth(int userId, DateTime newBirthOfDate)
        {
            var user = _db.TblUser.FirstOrDefault(p => p.IUserId == userId);

            if (user != null)
            {
                user.DBirthDate = newBirthOfDate;

                _db.TblUser.Update(user);

                _db.SaveChanges();

                return true;
            }

            return false;
        }

        public bool CheckEmail(string email)
        {
            return _db.TblUser.FirstOrDefault(p => p.SUserName == email && p.BEnable == 1 && p.BArchived == 0) != null;
        }

        public TblUser Login(string email, string password)
        {
            var existingUser = _db.TblUser.FirstOrDefault(p => p.SUserName == email && p.SPassword == password && p.BEnable == 1 && p.BArchived == 0);

            return existingUser;
        }

        public void UpdateUserRefreshToken(int userId, string refreshToken, DateTime? refreshTokenEndDate)
        {
            var user = _db.TblUser.FirstOrDefault(p => p.IUserId == userId);

            if (user != null)
            {
                user.SRefreshToken = refreshToken;
                user.DRefreshTokenEndDate = refreshTokenEndDate;

                _db.TblUser.Update(user);
                _db.SaveChanges();
            }
        }

        public TblUser GetUserByRefreshToken(string refreshToken)
        {
            return _db.TblUser.FirstOrDefault(p => p.SRefreshToken == refreshToken);
        }

        public TblUser Register(string firstName, string surname, string phoneNumber, string email, string password)
        {

            var existing = _db.TblUser.FirstOrDefault(p => p.SUserName == email);

            if (existing != null)
                throw new ApiException("Bu E-mail adresi ile başka bir kullanıcı mevcut.");

            var now = DateTime.Now;

            var user = new TblUser();

            user.IUserTypeId = 1;
            user.IUserStatusId = 1;
            user.IAddressId = 0;
            user.SFirstName = firstName;
            user.SSurname = surname;
            user.SUserFullName = firstName + " " + surname;
            user.SUserName = email;
            user.SPassword = password;
            user.SBusinessPhone = phoneNumber;
            user.BEnable = 1;
            user.BArchived = 0;
            user.IPasswordReminderControl = 0;
            user.DPasswordReminderControlDt = DateTime.Now.AddYears(1);
            user.IWrongPasswordEntryId = 0;
            user.DCreateDate = now;
            user.DCreateDt = now;
            user.IGenderId = 0;

            _db.TblUser.Add(user);

            _db.SaveChanges();

            return user;

        }
    }
}
