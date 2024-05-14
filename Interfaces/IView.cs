using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_work.Interfaces
{
    public interface IView
    {
        string Username { get; }
        string Password { get; }
        void ShowRole(string role);
    }
}
