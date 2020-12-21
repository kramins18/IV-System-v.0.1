using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public class AdminService
    {
        private Context _context;

        public AdminService(Context context)
        {
            _context = context;
        }
        public IEnumerable<Admin> getAllAdmins()
        {
            return _context.Admin.ToList();
        }
    }
}
