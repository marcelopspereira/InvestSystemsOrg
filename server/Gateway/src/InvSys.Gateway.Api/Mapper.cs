﻿using System.Collections.Generic;
using System.Globalization;
using AutoMapper;
using InvSys.Companies.Api.Client.Proxy.Models;
using InvSys.Gateway.Core.Models;
using InvSys.Shared.Core.Model;

namespace InvSys.Gateway.Api
{
    public static class Mapper
    {
        public static void Configure(IMapperConfigurationExpression config)
        {
            // Company
            config.CreateMap<Company, CompanySummary>(MemberList.Destination);
            config.CreateMap<Company, CompanyDetails>(MemberList.Destination);

            // Page of Company
            config.CreateMap<PageCompany, Page<CompanySummary>>();

            // Generic configuration
            config.AllowNullCollections = true;
        }
    }
}
