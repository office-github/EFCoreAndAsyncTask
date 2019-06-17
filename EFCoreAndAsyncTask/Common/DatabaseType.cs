using System;

namespace EFCoreAndAsyncTask.Common
{
  [Flags]
  public enum DatabaseType
  {
    SqlServer = 1,
    MySQL = 2,
    Oracle = 3,
    MangoDB = 4
  }
}
