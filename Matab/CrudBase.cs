using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public abstract class CrudBase<T>
    {
        private readonly string _connectionString;

        public CrudBase(string connectionString)
        {
            _connectionString = connectionString;
        }
        public abstract string Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();

    }
}
