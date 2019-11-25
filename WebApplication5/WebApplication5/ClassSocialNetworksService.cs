using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    /// <summary>
    /// Класс для работы с гугл и твилио
    /// </summary>
    public class ClassSocialNetworksService
    {
        private readonly string googleToken;
        private readonly string twilioToken;
        public ClassSocialNetworksService(IOptions<SocialMediaOption> options)
        {
            googleToken = options.Value.GoogleToken;
            twilioToken = options.Value.TwilioToken;
        }
        public void ToDo()
        {
            // используем googleToken и twilioToken
        }
    }
}
