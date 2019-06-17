using System;

namespace EFCoreAndAsyncTask.SQL_Providers
{
  public interface IRepository<T>: IDisposable where T: BaseEntity
  {
  }
}
