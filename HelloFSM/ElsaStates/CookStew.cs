using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM.ElsaStates
{
    public class CookStew:State<MinerWife>
    {
        private static CookStew instance;
        public static CookStew Instance
        {
            get
            {
                if (instance == null) instance = new CookStew();
                return instance;
            }
        }

        public void Enter(MinerWife wife)
        {
            if(!wife.Cooking())
            {
                System.Console.WriteLine(wife.Name+":Puttin the stew in the oven");
                MessageDispatcher.Instance.DispatchMessage(1.5, wife.ID, wife.ID, (int)message_type.Msg_StewReady, MessageDispatcher.NO_ADDITIONAL_INFO);
                wife.SetCooking(true);
            }
        }

        public void Excute(MinerWife gameEntity)
        {
            throw new NotImplementedException();
        }

        public void Exit(MinerWife gameEntity)
        {
            throw new NotImplementedException();
        }

        public bool OnMessage(MinerWife wife, Telegram msg)
        {
            switch (msg.Msg)
            {
                case (int)message_type.Msg_StewReady:
                    System.Console.WriteLine("Message received by:" + wife.Name + " at time:" + DateTime.Now.ToString());
                    System.Console.WriteLine(wife.Name + ": Stew ready ! let`s eat");
                    //todo implement minerID
                    int minerID = 0;
                    MessageDispatcher.Instance.DispatchMessage(MessageDispatcher.SEND_MSG_IMMEDIATELY, wife.ID, minerID, (int)message_type.Msg_StewReady, MessageDispatcher.NO_ADDITIONAL_INFO);
                    return true;
            }
            return false;
        }
    }
}
