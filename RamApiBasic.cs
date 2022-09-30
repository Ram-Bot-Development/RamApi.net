using DalSoft.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamApidotnet
{

    public class RamApiBasic
    {

        public static string APIURL = $"https://api.rambot.xyz";

        public static async Task<dynamic> helloAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/hello/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> _8ballAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/8ball/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> cuddleAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/cuddle";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> goodmorningAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/gm/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> goodnightAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/gn/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> hugAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/hug";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> kissAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/kiss";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> slapAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/slap";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> sickAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/sick";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> tiredAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/tired";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> cryAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/cry/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> laughAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/laugh";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> birthdayAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/bday/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> versionAsync(string Version)
        {
            string requestUrl = APIURL + $"/public/version/{Version}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();;
        }
       
        public static async Task<dynamic> memeAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/meme";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> catsAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/cats";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> animeAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/anime";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> ramAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/ram";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> nekoparaAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/nekopara";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
        public static async Task<dynamic> ratelimitAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/basic/{Version}/public/ratelimit";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Get();
        }
    }



}
