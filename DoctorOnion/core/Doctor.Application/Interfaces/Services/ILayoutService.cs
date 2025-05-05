using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Application.Interfaces.Services
{
    public interface ILayoutService
    {
        Task<Dictionary<string,string>> GetLayoutAsync();
    }
}
