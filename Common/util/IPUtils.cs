namespace JMWebAPI.Common.util
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    public class IPUtils
    {
        private static readonly string DbPath = "data/ip2region.xdb";
        private static Searcher _searcher;
        private readonly ILogger<IPUtils> _logger;

        public IPUtils(ILogger<IPUtils> logger)
        {
            _logger = logger;
            Init().Wait();
        }

        private async Task Init()
        {
            try
            {
                // Load resource file from embedded resources
                using var inputStream = GetType().Assembly.GetManifestResourceStream(DbPath);
                if (inputStream == null)
                {
                    throw new FileNotFoundException($"Resource not found: {DbPath}");
                }

                // Copy resource file to a temporary file
                var tempDbPath = Path.GetTempFileName();
                using var outputFileStream = File.Create(tempDbPath);
                await inputStream.CopyToAsync(outputFileStream);

                // Initialize Searcher object using the temporary file
                _searcher = Searcher.NewWithFileOnly(tempDbPath);
            }
            catch (Exception e)
            {
                _logger.LogError($"IpRegionUtil initialization ERROR, {e.Message}");
            }
        }

        public string GetIpAddr(HttpRequest request)
        {
            string ip = string.Empty;
            try
            {
                if (request == null)
                {
                    return string.Empty;
                }

                ip = request.Headers["x-forwarded-for"];
                if (CheckIp(ip))
                {
                    ip = request.Headers["Proxy-Client-IP"];
                }
                if (CheckIp(ip))
                {
                    ip = request.Headers["WL-Proxy-Client-IP"];
                }
                if (CheckIp(ip))
                {
                    ip = request.Headers["HTTP_CLIENT_IP"];
                }
                if (CheckIp(ip))
                {
                    ip = request.Headers["HTTP_X_FORWARDED_FOR"];
                }
                if (CheckIp(ip))
                {
                    ip = request.HttpContext.Connection.RemoteIpAddress?.ToString();
                    if (ip == "127.0.0.1" || ip == "::1")
                    {
                        // Get local machine's IP address
                        ip = GetLocalAddr();
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError($"IPUtils ERROR, {e.Message}");
            }

            // If using a proxy, get the first IP address
            if (!string.IsNullOrEmpty(ip) && ip.Contains(','))
            {
                ip = ip.Split(',')[0];
            }

            return ip;
        }

        private bool CheckIp(string ip)
        {
            const string unknown = "unknown";
            return string.IsNullOrEmpty(ip) || string.Equals(ip, unknown, StringComparison.OrdinalIgnoreCase);
        }

        private string GetLocalAddr()
        {
            try
            {
                return Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
            }
            catch (Exception e)
            {
                _logger.LogError($"InetAddress.GetLocalHost()-error, {e.Message}");
            }
            return null;
        }

        public string GetRegion(string ip)
        {
            if (_searcher == null)
            {
                _logger.LogError("Searcher is not initialized");
                return null;
            }

            try
            {
                return _searcher.Search(ip);
            }
            catch (Exception e)
            {
                _logger.LogError($"IpRegionUtil ERROR, {e.Message}");
                return null;
            }
        }
    }

    public class Searcher
    {
        public static Searcher NewWithFileOnly(string path)
        {
            // Implement logic to create a new Searcher instance with the given file
            throw new NotImplementedException();
        }

        public string Search(string ip)
        {
            // Implement logic to search for the IP address's region
            throw new NotImplementedException();
        }
    }

}
