using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phani.StrategyFactoryPattern.Factory;
using Phani.StrategyPattern.Models;
using Phani.StrategyPattern.Providers;
using Phani.StrategyPattern.Repository;

namespace Phani.StrategyPattern.Controllers
{
    [ApiController]
    [Route("[developers]")]
    public class DeveloperController : ControllerBase
    {
        private readonly ILogger<DeveloperController> _logger;
        private readonly IDeveloperRepository _developerRepository;
        private readonly IDeveloperFactory _developerFactory;

        public DeveloperController(ILogger<DeveloperController> logger,
                                    IDeveloperRepository developerRepository,
                                    IDeveloperFactory developerFactory)
        {
            _logger = logger;
            _developerRepository = developerRepository;
            _developerFactory = developerFactory;
        }

        [HttpGet("{id}/developers")]
        public ActionResult<Language> GetPromotionToken(string id)
        {
            var details = _developerRepository.GetDeveloperDetails(id);
            if(details == null)
            {
                throw new NotImplementedException();
            }
            var result = _developerFactory.Developer(details.LanguageType);

            return new Language
            {
                Result = result
            };
        }
    }
}
