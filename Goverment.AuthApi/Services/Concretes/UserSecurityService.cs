﻿using Core.CrossCuttingConcerns.Exceptions;
using Core.Mailing.MailKitImplementations;
using Core.Security.Entities;
using Goverment.AuthApi.Repositories.Abstracts;
using Goverment.AuthApi.Services.Constants;

namespace Goverment.AuthApi.Services.Concretes
{
    public class UserSecurityService
    {

        private readonly IUserRepository _userRepository;

        public UserSecurityService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public  User CheckUserBlock(User user)
        {
            if (user.UserLoginSecurity.IsAccountBlock)
            {
                DateTime endBlockTime = user.UserLoginSecurity.AccountUnblockedTime ?? DateTime.UtcNow;
                int minute = (int)(endBlockTime - DateTime.UtcNow).TotalMinutes;
                if (minute > 0)
                    throw new AuthorizationException("Həddindən çox giriş cəhdi. Bir müddət sonra yenidən yoxlayın");
                else
                {
                    user.UserLoginSecurity.IsAccountBlock = false;
                    ClearIfRetryCountMax(user);
                }

            }
            return user;
        }



        public  void SendWarningMessage(User user)
        {
            if (user.UserLoginSecurity.LoginRetryCount is 2)
                Gmail.SendWarningMessage(user);
        }

        public  async Task LoginLimitExceed(User user)
        {
            if (user.UserLoginSecurity.LoginRetryCount is 4)
            {
                user.UserLoginSecurity.IsAccountBlock = true;
                user.UserLoginSecurity.AccountBlockedTime = DateTime.UtcNow;
                user.UserLoginSecurity.AccountUnblockedTime = DateTime.UtcNow.AddMinutes(15);

            }
            else if (user.UserLoginSecurity.LoginRetryCount is 9)
            {
                user.UserLoginSecurity.IsAccountBlock = true;
                user.UserLoginSecurity.AccountBlockedTime = DateTime.UtcNow;
                user.UserLoginSecurity.AccountUnblockedTime = DateTime.UtcNow.AddHours(1);

            }
            else if (user.UserLoginSecurity.LoginRetryCount is 14)
            {
                user.UserLoginSecurity.IsAccountBlock = true;
                user.UserLoginSecurity.AccountBlockedTime = DateTime.UtcNow;
                user.UserLoginSecurity.AccountUnblockedTime = DateTime.UtcNow.AddDays(1); ;

            }

            user.UserLoginSecurity.LoginRetryCount += 1;
            await _userRepository.UpdateAsync(user);
        }

        public void UnblockUser(User user) 
        {
            user.UserLoginSecurity.LoginRetryCount = 0;
        }

        public  void CheckIDTokenExpireTime(User user)
        {
            if (user.IDTokenExpireDate < DateTime.UtcNow) throw new BusinessException(Messages.IDTokenExpired);
        }

        private void ClearIfRetryCountMax(User user)
        {
            if (user.UserLoginSecurity.LoginRetryCount is 15)
                user.UserLoginSecurity.LoginRetryCount = 0;
        }
    }
}