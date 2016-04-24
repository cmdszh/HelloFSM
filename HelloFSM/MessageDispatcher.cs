
#define DispatchTT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class MessageDispatcher
    {
        public const int SEND_MSG_IMMEDIATELY=0;
        public const object NO_ADDITIONAL_INFO = null;
        private List<Telegram> PriorityQ=new List<Telegram>();
        private void Discharge(BaseGameEntity pReciver, Telegram msg)
        {
            pReciver.HandleMessage(msg);
        }

        private MessageDispatcher() { }

        public static MessageDispatcher Instance;

        public void DispatchMessage(double delay,int sender,int recevier,int msg,object ExtraInfo)
        {
            BaseGameEntity pRecevier = EntityManager.Instance.GetEntityFromID(recevier);
            Telegram telegram =new Telegram(delay,sender,recevier,msg,ExtraInfo);
            if (delay <= 0)
            {
                Discharge(pRecevier, telegram);
            }
            else
            {
                telegram.DispatchTime = DateTime.UtcNow.Ticks + delay;
                int index = 0;
                for (int i = 0; i < PriorityQ.Count; i++)
                {
                    if (PriorityQ[i].DispatchTime <= telegram.DispatchTime)
                    {
                        index = i + 1;
                    }
                }
                PriorityQ.Insert(index, telegram);
            }
        }

        public void DispatchDelayedMessage()
        {
            double currentTime = DateTime.UtcNow.Ticks;
            while(PriorityQ.Count>0 && PriorityQ[0].DispatchTime<=currentTime)
            {
                Telegram telegram = PriorityQ[0];
                BaseGameEntity pReceiver = EntityManager.Instance.GetEntityFromID(telegram.Receiver);
                Discharge(pReceiver, telegram);
                PriorityQ.RemoveAt(0);
            }
        }

    }
}
