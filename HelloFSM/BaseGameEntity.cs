using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class BaseGameEntity
    {
        private static int m_kId;
        public void SetId(int id)
        {
            id = m_kId;
        }

        public BaseGameEntity(int id)
        {
            SetId(id);
        }


        public virtual void Update()
        {
           
        }

        public int ID
        {
            get { return m_kId; }
        }

        public virtual bool HandleMessage(Telegram msg)
        { return false; }
        
    }
}
