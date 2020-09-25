using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.DB
{
    interface IUserMgt
    {
        Boolean databaseOperation(user pUser, string pConnectionString);
    }
}
