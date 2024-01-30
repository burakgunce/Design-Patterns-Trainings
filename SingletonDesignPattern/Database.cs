using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Database
    {
        private static Database db;
        private static object _lockObject;//multi thread yapılar ıcın
        
        //singleton da ctor lar dısardan erişime kapalı olması lazım
        private Database() 
        {
            
        }

        public static Database GetInstance()
        {
            //SingleThreadd yapılar için
            //if (db == null)
            //{
            //    db = new Database();
            //}
            //return db;

            if (db == null)
            {
                lock (_lockObject)
                {
                    db = new Database();
                    if (db == null)
                    {
                        db = new Database();
                    }
                }
            }
            return db;
        }
    }
}
