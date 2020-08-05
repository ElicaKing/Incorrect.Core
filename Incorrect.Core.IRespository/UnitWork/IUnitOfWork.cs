using Incorrect.Core.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Incorrect.Core.IRespository { 
    public interface IUnitOfWork
    {
        MyDbContext GetDbContext();
        Task<int> SaveChangesAsync();
    }
}
