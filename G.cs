using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWproject
{
    public static class G
    {
     public static  authentificationEntities context;
        public static bool initializare()
        {
            try
            {
                 context = new authentificationEntities();
                
                return true;
                
            }
            catch
            {
                return false;
            }
        }
      
        
    }
}