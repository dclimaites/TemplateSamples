using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayerPatternLibrary.Model;

namespace ThreeLayerPatternLibrary.Repository
{
    public interface IRepositoryBase
    {
        Task<ExampleModel> GetModel();
        SqlConnection GetConnection();

    }
}
