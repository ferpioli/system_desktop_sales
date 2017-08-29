using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas.DAL
{
    public class DataContextFactory
    {

        private static sistemaDataContext dataCotext;
        public static  sistemaDataContext DataContext
        {
            get
            {
                if (dataCotext == null)
                    dataCotext = new sistemaDataContext();
                return dataCotext;
            }
        }

    }
}
