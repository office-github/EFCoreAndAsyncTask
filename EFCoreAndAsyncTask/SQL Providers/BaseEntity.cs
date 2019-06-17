using System;

namespace EFCoreAndAsyncTask.SQL_Providers
{
  public abstract class BaseEntity
  {
    public long Id { get; set; }
    public long CreatedBy { get; set; }
    public long UpdatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
  }
}
