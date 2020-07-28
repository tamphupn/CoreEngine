using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;

namespace CoreEngine.BuildingBlocks.HeaderIdentity
{
    /// <summary>
    /// Implement service get user identity in header
    /// </summary>
    public class IdentityService : IIdentityService
    {
        private IHttpContextAccessor _context;

        public IdentityService(IHttpContextAccessor context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Get current user organization id (company)
        /// </summary>
        /// <returns></returns>
        public long? GetUserOrganizationId()
        {
            long? companyId = null;

            var context = _context.HttpContext;
            if (context != null && context.Request.Headers.TryGetValue(HeaderDefault.COMPANY_ID_HEADER_NAME, out StringValues headerValues))
            {
                string valueToParse = headerValues.FirstOrDefault();
                if (long.TryParse(valueToParse, out long tryValue))
                {
                    companyId = tryValue;
                }
            }

            return companyId;
        }

        /// <summary>
        /// get current user id
        /// </summary>
        /// <returns></returns>
        public long? GetUserIdentity()
        {
            long? userId = null;

            var context = _context.HttpContext;
            if (context != null && context.Request.Headers.TryGetValue(HeaderDefault.USER_ID_HEADER_NAME, out StringValues headerValues))
            {
                string valueToParse = headerValues.FirstOrDefault();
                if (long.TryParse(valueToParse, out long tryValue))
                {
                    userId = tryValue;
                }
            }

            return userId;
        }

        /// <summary>
        /// Get current user unit id (organization)
        /// </summary>
        /// <returns></returns>
        public long? GetUserUnitId()
        {
            long? orgId = null;

            var context = _context.HttpContext;
            if (context != null && context.Request.Headers.TryGetValue(HeaderDefault.ORG_ID_HEADER_NAME, out StringValues headerValues))
            {
                string valueToParse = headerValues.FirstOrDefault();
                if (long.TryParse(valueToParse, out long tryValue))
                {
                    orgId = tryValue;
                }
            }

            return orgId;
        }
    }
}