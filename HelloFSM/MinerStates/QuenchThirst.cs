using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class QuenchThirst:StateBase<Miner>
    {
        private static QuenchThirst instance;
        public static QuenchThirst Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuenchThirst();
                return instance;
            }
        }

        public void Enter(Miner miner)
        {
            //send message to mosca i`m in now
            //todo get id of mosca
            int moscaId=0;
            int msgType = 1;
            Telegram msg = new Telegram(MessageDispatcher.SEND_MSG_IMMEDIATELY, miner.ID, moscaId, msgType, MessageDispatcher.NO_ADDITIONAL_INFO);
            MessageDispatcher.Instance.DispatchMessage(MessageDispatcher.SEND_MSG_IMMEDIATELY, msg.Sender, msg.Receiver, msg.Msg, msg.ExtraInfo);

        }

        public void Excute(Miner gameEntity)
        {
            throw new NotImplementedException();
        }

        public void Exit(Miner gameEntity)
        {
            throw new NotImplementedException();
        }


        public bool OnMessage(Miner pReceiver, Telegram telegram)
        {
            throw new NotImplementedException();
        }
    }
}
