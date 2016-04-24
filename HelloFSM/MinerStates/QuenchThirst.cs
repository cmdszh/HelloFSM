using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class QuenchThirst:State<Miner>
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
