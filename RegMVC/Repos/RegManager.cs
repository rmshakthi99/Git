using Microsoft.Extensions.Logging;
using RegMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace RegMVC.Repos
{
    public class RegManager : IRepo<Registration>
    {
        private RegContext _context;
        private ILogger<RegManager> _logger;

        public  RegManager(RegContext context, ILogger<RegManager> logger)
            {

            _context = context;
            _logger = logger;
                }

        public void Add(Registration t)
        {
            try
            {
                _context.Registrations.Add(t);
                _context.SaveChanges();

            }
            catch(Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }
        public IEnumerable<Registration> GetAll()
        {
            try
            {
                if (_context.Registrations.Count() == 0)
                    return null;
                return _context.Registrations.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public bool Login(Registration t)
        {
            try
            {
                Registration reg = _context.Registrations.SingleOrDefault(u => u.Username == t.Username);
            }
           
        }
    }
}
