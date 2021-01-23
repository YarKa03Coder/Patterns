using System.Data.Entity;

namespace Patterns.Creational.Singleton
{
    public class Singleton : DbContext
    {
        private static volatile Singleton _instance = null;
        private static readonly object SyncRoot = new object();

        static Singleton()
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
        }
        
        // Configure string by yourself
        private Singleton()
            : base("data source=(LocalDB)\\MSSQLLocalDB;initial catalog=MyDatabase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        { }

        public static Singleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance is null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }

                return _instance;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _instance = null;
        }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> Players { get; set; }
    }
}