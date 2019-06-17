using EFCoreAndAsyncTask.Common;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EFCoreAndAsyncTask.SQL_Providers
{
  public class DatabaseContext : DbContext, IDbContext
  {
    private readonly string connectionString;
    private readonly DbConnection connection;
    private readonly DatabaseType databaseType;

    public DatabaseContext(DatabaseType type = DatabaseType.SqlServer)
    {
      this.databaseType = type;
    }

    public DatabaseContext(DbConnection connection, DatabaseType type = DatabaseType.SqlServer)
    {
      this.connection = connection;
      this.databaseType = type;
    }

    public DatabaseContext(string connectionString, DatabaseType type = DatabaseType.SqlServer)
    {
      this.connectionString = connectionString;
      this.databaseType = type;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      if (!optionsBuilder.IsConfigured)
      {
        this.ConfigureDatabase(optionsBuilder);
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);


    }

    private void ConfigureDatabase(DbContextOptionsBuilder optionsBuilder)
    {
      switch (databaseType)
      {
        case DatabaseType.SqlServer:
          if (!string.IsNullOrEmpty(connectionString))
          {
            optionsBuilder.UseSqlServer(connectionString);
          }
          else
          {
            optionsBuilder.UseSqlServer(connection);
          }
          break;

        default: break;
      }
    }
  }
}
