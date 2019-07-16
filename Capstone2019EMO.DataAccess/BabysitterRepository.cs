using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone2019EMO.Common;
using Capstone2019EMO.DataAccess.Common;
using Capstone2019EMO.Model;

namespace Capstone2019EMO.DataAccess
{
    /// <summary> 
    /// Purpose: Data Access Repository Class [EmployeesRepository] for the table [dbo].[Babysitter]. 
    /// </summary> 
    public class BabysitterRepository : IRepository<BabysitterEntity>, IDisposable
    {
        #region Private Declarations 

        private LoggingHandler _loggingHandler;
        private DataHandler _dataHandler;
        private ConfigurationHandler _configurationHandler;
        private DbProviderFactory _dbProviderFactory;
        private string _connectionString;
        private string _connectionProvider;
        private int _errorCode, _rowsAffected;
        private bool _bDisposed;

        #endregion

        #region Class Methods 

        public bool Insert(BabysitterEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(BabysitterEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public BabysitterEntity SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BabysitterEntity> SelectAll()
        {
            throw new NotImplementedException();
        }

        public BabysitterRepository()
        {
            //Repository Initializations 
            _configurationHandler = new ConfigurationHandler();
            _loggingHandler = new LoggingHandler();
            _dataHandler = new DataHandler();
            _connectionString = _configurationHandler.ConnectionString;
            _connectionProvider = _configurationHandler.ConnectionProvider;
            _dbProviderFactory = DbProviderFactories.GetFactory(_connectionProvider);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool bDisposing)
        {
            // Check to see if Dispose has already been called. 
            if (!_bDisposed)
            {
                if (bDisposing)
                {
                    // Dispose managed resources. 
                    _configurationHandler = null;
                    _loggingHandler = null;
                    _dataHandler = null;
                    _dbProviderFactory = null;
                }
            }
            _bDisposed = true;
        }

        #endregion
    }
}
}
