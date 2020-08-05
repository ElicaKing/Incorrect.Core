using Incorrect.Core.Common;
using Incorrect.Core.IRespository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.Respository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext myDbContext;

        public UnitOfWork(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        public MyDbContext GetDbContext()
        {
            return myDbContext;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await myDbContext.SaveChangesAsync();
        }
    }
}
