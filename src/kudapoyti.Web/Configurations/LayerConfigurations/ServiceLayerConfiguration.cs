﻿using AutoMapper;
using kudapoyti.DataAccess.Interfaces;
using kudapoyti.DataAccess.Repositories;
using kudapoyti.Service.Common.Security;
using kudapoyti.Service.Interfaces;
using kudapoyti.Service.Interfaces.Common;
using kudapoyti.Service.Services.Common;
using kudapoyti.Service.Services.kudapoytiService;

namespace kudapoyti.Web.Configurations.LayerConfigurations
{
    public static class  ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAdminRegistrService, AdminRegistrService>();
            services.AddScoped<IAuthManager, AUthManager>();
            services.AddScoped<IAdminAccountService, AdminAccountService>();
            services.AddTransient<IPlaceService, PlaceService>();
            services.AddScoped<IPaginationService, PaginatonService>();
            services.AddScoped<IImageService, ImageService>();
        }

     
    }
}