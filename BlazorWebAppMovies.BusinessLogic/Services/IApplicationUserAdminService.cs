﻿using BlazorWebAppMovies.BusinessLogic.Entities;
using BlazorWebAppMovies.BusinessLogic.Entities.Dtos;

namespace BlazorWebAppMovies.BusinessLogic.Services;

public interface IApplicationUserAdminService
{
    Task<ApplicationUserAdminDto?> AddAsync(ApplicationUserAdminDto applicationUserAdminDto);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<ApplicationUserAdminDto?> EditAsync(ApplicationUserAdminDto applicationUserAdminDto);
    Task<List<ApplicationUser>?> GetAllAsync(string userName);
    Task<ApplicationUserAdminDto?> GetByIdAsync(string userName, Guid id);
}
