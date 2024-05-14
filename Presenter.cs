using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_work
{
    using ind_work.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class Presenter : IPresenter
    {
        private IView _view;
        private List<User> _users;

        public Presenter(IView view)
        {
            _view = view;
            _users = new List<User>
        {
            new User { Username = "admin", Password = "admin", Role = "Admin" },
            new User { Username = "user", Password = "user", Role = "User" },
            new User { Username = "guest", Password = "guest", Role = "Guest" }
        };
        }

        public void Authorize()
        {
            var user = _users.FirstOrDefault(u => u.Username == _view.Username && u.Password == _view.Password);
            if (user != null)
            {
                _view.ShowRole(user.Role);
            }
            else
            {
                _view.ShowRole("Unauthorized");
            }
        }
    }
}
