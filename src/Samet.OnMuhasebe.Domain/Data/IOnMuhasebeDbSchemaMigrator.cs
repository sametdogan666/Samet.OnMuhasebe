using System.Threading.Tasks;

namespace Samet.OnMuhasebe.Data;

public interface IOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
