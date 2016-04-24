using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
   public class ActorManager
    {
       private Dictionary<int, ActorBase> m_kEntityMap=new Dictionary<int,ActorBase>();
       private ActorManager()
       { }

       public static ActorManager Instance;
       public void RegesterEntity(ActorBase entity)
       {
           throw new NotImplementedException();
       }

       public ActorBase GetEntityFromID(int id)
       {
           throw new NotImplementedException();
       }

       public void RemoveEntity(ActorBase entity)
       {
           throw new NotImplementedException();
       }



    }
}
