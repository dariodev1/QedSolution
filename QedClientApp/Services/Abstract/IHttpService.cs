using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QedClientApp.Services.Abstract
{
    public interface IHttpService
    {
        Task<string> PerformApiOperationAsync(string? number1, string? number2);
    }
}
