using BussinessObject.Models;

namespace DataAccessLayer
{
    public class SingletonBase<T> where T : class, new()
    {
        private static T _instance;
        private static readonly object _lock = new object();
        public static ProjectPrn211Context _context { get; private set; }
        public static T Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                    return _instance;
                }
            }
        }
        public static ProjectPrn211Context GetContext()
        {
            if (_context == null)
            {
                _context = new ProjectPrn211Context();
            }
            return _context;
        }
    }
}
