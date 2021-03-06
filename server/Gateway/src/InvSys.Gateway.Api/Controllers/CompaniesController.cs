﻿using System;
using System.Threading.Tasks;
using AutoMapper;
using InvSys.Companies.Api.Client.Proxy.Models;
using InvSys.Gateway.Core.Models;
using InvSys.Gateway.Core.Services;
using InvSys.Shared.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Swashbuckle.SwaggerGen.Annotations;

namespace InvSys.Gateway.Api.Controllers
{
    //[Authorize(Policy = "Admin")]
    [Route("api/[controller]")]
    public class CompaniesController : Controller
    {
        private readonly ICompaniesService _dashboardService;
        private readonly ILogger<CompaniesController> _logger;
        private readonly IStringLocalizer<CompaniesController> _localizer;

        public CompaniesController(ICompaniesService dashboardService, ILogger<CompaniesController> logger, IStringLocalizer<CompaniesController> localizer)
        {
            _dashboardService = dashboardService;
            _logger = logger;
            _localizer = localizer;
        }

        // GET api/companies        
        [HttpGet]
        [AllowAnonymous]
        [SwaggerOperation("get-companies")]
        [SwaggerResponseRemoveDefaults]
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(Page<CompanySummary>))]
        [SwaggerResponse(System.Net.HttpStatusCode.BadRequest, Description = "Failed to get companies")]
        [Produces("application/json", Type = typeof(Page<CompanySummary>))]
        public async Task<IActionResult> Get([FromQuery] Query query = null)
        {
            _logger.LogInformation("Getting companies");
            try
            {
                var pageOfCompanies = await _dashboardService.GetCompanies(query);
                return Ok(pageOfCompanies);
            }
            catch (Exception ex)
            {
                _logger.LogError($"{_localizer["Failed to get companies"]}" + ex);
                return BadRequest();
            }
        }

        // GET api/companies/MENT
        [HttpGet("{symbol}")]
        [AllowAnonymous]
        [SwaggerOperation("get-company")]
        [SwaggerResponseRemoveDefaults]
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(CompanyDetails))]
        [SwaggerResponse(System.Net.HttpStatusCode.BadRequest, Description = "Failed to get company")]
        [Produces("application/json", Type = typeof(CompanyDetails))]
        public async Task<IActionResult> Get(string symbol)
        {
            _logger.LogInformation($"Getting company {symbol}");
            try
            {
                var company = await _dashboardService.GetCompany(symbol);
                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get company {symbol}" + ex);
                return BadRequest();
            }
        }
    }
}
