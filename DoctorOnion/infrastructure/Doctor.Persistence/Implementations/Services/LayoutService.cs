using Doctor.Application.Interfaces.Services;
using Doctor.Persistence.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor.Persistence.Implementations.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext context;

        public LayoutService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Dictionary<string, string>> GetLayoutAsync()
        {
           return await context.ContactDatas.ToDictionaryAsync(k=>k.Key, k=>k.Value);
        }
    }
}
