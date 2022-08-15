using DalSoft.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamApidotnet
{
    
    public class RamApi
    {
        
        public static string APIURL = $"https://api.rambot.xyz";
        
        public static async Task<dynamic> helloAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/{Version}/public/hello/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> _8ballAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/{Version}/public/8ball/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> cuddleAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/cuddle";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> goodmorningAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/{Version}/public/gm/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> goodnightAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/{Version}/public/gn/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> hugAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/hug";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> kissAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/kiss";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> slapAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/slap";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> sickAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/sick";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> tiredAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/tired";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> cryAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/{Version}/public/cry/{lang}";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> laughAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/laugh";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> birthdayAsync(string ApiKey, string Version, string lang = "english")
        {
            string requestUrl = APIURL + $"/{Version}/public/bday";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
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

            return await client.Get();
        }
        public static async Task<dynamic> apiinfoAsync(string ApiKey)
        {
            string requestUrl = APIURL + $"/public/apiinfo";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> memeAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/meme";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> catsAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/cats";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> animeAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/anime";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> ramAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/ram";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
        public static async Task<dynamic> nekoparaAsync(string ApiKey, string Version)
        {
            string requestUrl = APIURL + $"/{Version}/public/nekopara";

            dynamic client = new RestClient(requestUrl, new Config().UseRetryHandler(
                 maxRetries: 5,
                    waitToRetryInSeconds: 6,
                    maxWaitToRetryInSeconds: 10,
                    backOffStrategy: DalSoft.RestClient.Handlers.RetryHandler.BackOffStrategy.Linear
                ));

            return await client.Headers(new Dictionary<string, string> { { "api-key", ApiKey } }).Get();
        }
    }



}
