using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KirschJanosMarkSajatRepoLayer.Adatbazis;
using KirschJanosMarkSajatRepoLayer.Repository;
using System.Data;

namespace KirschJanosMarkSajatRepoLayer.Service
{
    class AccountService
    {
        AccountRepo ar;

        public AccountService()
        {
            ar = new AccountRepo();
        }

        public DataTable betoltAdattabla(string tablaNev)
        {
            return ar.getTabla(tablaNev);
        }

    }
}
