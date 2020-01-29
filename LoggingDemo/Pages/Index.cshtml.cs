using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Logging Levels
            _logger.LogTrace("This is a trace log");
            _logger.LogDebug("This is a debug log");
            _logger.LogInformation(1234,"All your base are belong to us.  Also, this is an info log");
            _logger.LogWarning("This is a warning log.");
            _logger.LogError("This is an error log.");
            _logger.LogCritical("This is a critical log.");

            // Advanced logging messages
            // _logger.LogError("The server went down temporarily at {Time}", DateTime.UtcNow);
            //
            // try
            // {
            //     throw new Exception("YOU FORGOT TO CATCH ME!");
            // }
            // catch (Exception ex)
            // {
            //     _logger.LogCritical(ex, "This is an example of a bad exception being thrown at {Time}",
            //         DateTime.UtcNow);
            //     Console.WriteLine(ex);
            //     throw;
            // }
        }
    }
}