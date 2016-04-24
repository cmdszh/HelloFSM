using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM.ElsaStates
{
   public class WifesGlobalState:State<MinerWife>
    {
        public void Enter(MinerWife gameEntity)
        {
            throw new NotImplementedException();
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
            switch(msg.Msg)
            {
                case (int)message_type.Msg_HiHoneyImHome:
                    {
                        System.Console.WriteLine("Message handled by "+wife.Name);
                        System.Console.WriteLine(" at time:" + DateTime.Now.ToString());
                        System.Console.WriteLine(wife.Name + ": Hi honey, Let me make you some of mah fine country stew");
                        wife.getFSM().ChangeState(CookStew.Instance);
                        return true;
                    }
            }
            return false;
        }

        public static State<MinerWife> Instance { get; set; }
    }
}
