using ThreeLayerPatternLibrary.Model;
using Dapper;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;
using ThreeLayerPatternLibrary.Model.DTO;

namespace ThreeLayerPatternLibrary.Repository
{
    public class RepositoryBase : IRepositoryBase
    {
        private string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Data Source=DESKTOP-LTGKJ1G;Initial Catalog=TESTE;Integrated Security=False;User Id=sysdba;Password=masterkey;MultipleActiveResultSets=true;";//TODO: Trocar pela entrada da String via Configuration appsettings.json
        }

        public async Task<ExampleModel> GetModel()
        {
            ExampleModel model;
            using (var con = GetConnection())
            {
                model = con.Query<ExampleModel, ExampleModelDTO, ExampleModel>("SELECT * FROM ExampleModel", (model, modelDB) =>
                {
                    model = new ExampleModel(modelDB.Name, modelDB.Age, modelDB.Id);
                    return model;
                }).FirstOrDefault();
            }

            return model;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this._connectionString);
        }
    }
}
