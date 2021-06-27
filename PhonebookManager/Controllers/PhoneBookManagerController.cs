using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhonebookManager.Model;
using PhonebookManager.Helpers;

namespace PhonebookManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneBookManagerController : Controller
    {

        private readonly ILogger<PhoneBookManagerController> _logger;

        public PhoneBookManagerController(ILogger<PhoneBookManagerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Entry> GetPhoneBookEntries(string searchKey)
        {
            searchKey = new EntrySanitiserHelper().RemoveSpecialCaracters(searchKey);
            return null;
        }
   
    }
}
