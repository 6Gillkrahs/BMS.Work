using System.Threading.Tasks;

namespace BMS.Work.Data;

public interface IWorkDbSchemaMigrator
{
    Task MigrateAsync();
}
