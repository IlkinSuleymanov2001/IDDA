﻿namespace Goverment.AuthApi.Business.Dtos.Request.Auth
{
    //todo validationun yaz 
    public class ResetUserPasswordRequest
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
