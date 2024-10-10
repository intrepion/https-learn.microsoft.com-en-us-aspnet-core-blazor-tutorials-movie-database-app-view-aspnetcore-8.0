﻿using Microsoft.AspNetCore.Identity;

namespace BlazorWebAppMovies.BusinessLogic.Entities;

public class ApplicationUserClaim : IdentityUserClaim<Guid>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
