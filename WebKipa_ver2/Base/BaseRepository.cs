using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using WebApp.Models;

namespace WebKipa_ver2.Base
{
    public class BaseRepository
    {
        public string LanguageCode { get; set; }
        private IOptions<AppSettings> _settings;
        public string ConnectionString
        {
            get
            {
                // get connnectString
                var conn = _settings.Value.DefaultConnection;
                return conn;
            }
        }
        private IDbConnection _connection;
        public BaseRepository(IOptions<AppSettings> settings)
        {
            try
            {
                this._settings = settings;
                _connection = new SqlConnection(ConnectionString);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <value>The connection.</value>
        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    string constr = ConnectionString;
                    _connection = new SqlConnection(constr);
                }
                if (_connection.State != ConnectionState.Open)
                {
                    try
                    {
                        _connection.Open();
                    }
                    catch (Exception)
                    {

                        _connection.Close();
                    }
                }
                return _connection;
            }
        }
    }
}
