using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloFSM.MinerStates;

namespace HelloFSM
{
    public class GoHomeAndSleepTilRestes:State<Miner>
    {
        private static GoHomeAndSleepTilRestes instance;
        public static GoHomeAndSleepTilRestes Instance
        {
            get
            {
                if (instance == null)
                    instance = new GoHomeAndSleepTilRestes();
                return instance;
            }
        }

        private GoHomeAndSleepTilRestes()
        {

        }

        public void Enter(Miner kMiner)
        {
            System.Console.WriteLine(kMiner.Name);
            System.Console.WriteLine("Walkin` home");
            kMiner.changeLocation(miner_location_type.Shack);
            int elsaID=0;
            MessageDispatcher.Instance.DispatchMessage(MessageDispatcher.SEND_MSG_IMMEDIATELY, kMiner.ID, elsaID, (int)message_type.Msg_HiHoneyImHome, MessageDispatcher.NO_ADDITIONAL_INFO);
        }

        public void Excute(Miner kMiner)
        {
            throw new NotImplementedException();
        }

        public void Exit(Miner kMiner)
        {
            throw new NotImplementedException();
        }


        public bool OnMessage(Miner miner, Telegram msg)
        {
            switch(msg.Msg)
            { 
                case (int)message_type.Msg_StewReady:
                    System.Console.WriteLine("Message handled by " + miner.Name + " at time:" + DateTime.Now.ToString());
                    System.Console.WriteLine(miner.Name + " :Okay hun, ahm a-comin!");
                    miner.getFSM().ChangeState(EatStew.Instance);
                    return true;
            }
            return false;
        }
    }
}
