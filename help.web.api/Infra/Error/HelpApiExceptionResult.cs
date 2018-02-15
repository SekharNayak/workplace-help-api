using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace help.web.api.Infra.Error
{
    public class HelpApiExceptionResult<T> :IHttpActionResult
        where T : Exception
    {
        private readonly T _data;
        private readonly HelpApiExceptionType _excType;
        private System.Net.HttpStatusCode _statusCode = System.Net.HttpStatusCode.InternalServerError;

        public string HttpConfigurationKey { get; private set; }

        public HelpApiExceptionResult(T data , HelpApiExceptionType excType)
        {
            _data = data;
            _excType = excType;
        }
        public HelpApiExceptionResult(T data, HelpApiExceptionType excType , System.Net.HttpStatusCode statusCode)
        {
            _data = data;
            _excType = excType;
            _statusCode = statusCode;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage();
            request.Properties.Add(HttpConfigurationKey, new HttpConfiguration());
            var response = request.CreateResponse(_statusCode, _data);
            return Task.FromResult(response);
        }
    }
}