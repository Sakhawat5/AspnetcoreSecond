using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacConfiguration.Models
{
    public class WebDisplay : IDisplay
    {
        private readonly HttpResponse _response;
        public WebDisplay(HttpResponse response)
        {
            _response = response;
        }

        public async void ShowNumber(string bigNumber)
        {
            await _response.WriteAsync(bigNumber);
        }
    }
}
