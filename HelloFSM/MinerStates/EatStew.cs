using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFSM.MinerStates
{
   public class EatStew:StateBase<Miner>
    {
       private static EatStew instance;
       public static EatStew Instance { get { if (instance == null)instance = new EatStew(); return instance; } }

        public void Enter(Miner gameEntity)
        {
            throw new NotImplementedException();
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
