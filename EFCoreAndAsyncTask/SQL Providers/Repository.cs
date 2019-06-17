using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreAndAsyncTask.SQL_Providers
{
  public class Repository<T> : IRepository<T> where T: BaseEntity
  {
    private readonly IDbContext context;

    private DbSet<T> entities => null;

    public Repository(IDbContext context)
    {
      this.context = context;
    }

    public void Dispose() => GC.SuppressFinalize(this);
  }
}
