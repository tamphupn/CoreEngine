using CoreEngine.BuildingBlocks.ApiStandard;
using CoreEngine.BuildingBlocks.HeaderIdentity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreEngine.BuildingBlocks.Controllers
{
    /// <summary>
    /// Defined base controller for web api
    /// </summary>
    public abstract partial class BaseApiController : Controller
    {
        private readonly IIdentityService _identityService;

        protected BaseApiController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        protected EndpointResult<ErrorResponse> ExceptionHandler(Exception ex)
        {
            //TO DO
            return null;
        }
    }
}