using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnixGeradorDeProvas.Repositorio
{
    public abstract class BaseRepositorioEntity
    {
        protected string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Unixs"].ConnectionString;

            }
        }
    }
}
