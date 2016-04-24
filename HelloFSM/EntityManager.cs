using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
   public class EntityManager
    {
       private Dictionary<int, BaseGameEntity> m_kEntityMap=new Dictionary<int,BaseGameEntity>();
       private EntityManager()
       { }

       public static EntityManager Instance;
       public void RegesterEntity(BaseGameEntity entity)
       {
           throw new NotImplementedException();
       }

       public BaseGameEntity GetEntityFromID(int id)
       {
           throw new NotImplementedException();
       }

       public void RemoveEntity(BaseGameEntity entity)
       {
           throw new NotImplementedException();
       }



    }
}
