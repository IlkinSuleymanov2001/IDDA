﻿using Goverment.Core.Persistance.Repositories;
using Goverment.Core.Security.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Security.Entities;
public  class User : Entity
{
    public string FirstName  { get; set; }
	public string Email { get; set; }
    public string? OtpCode { get; set; }
    public string? IDToken { get; set; }
    public DateTime? OptCreatedDate { get; set; }
    public DateTime? IDTokenExpireDate { get; set; }
    public bool IsVerify { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }
   

    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual UserLoginSecurity UserLoginSecurity { get; set; }
    public virtual UserOtpSecurity UserOtpSecurity { get; set; }

    public User()
    {
        UserRoles = new HashSet<UserRole>();
    }

}

