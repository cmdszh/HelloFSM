using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    class VisitBankAndDepositGold:StateBase<Miner>
    {
        private static VisitBankAndDepositGold instance;
        public static VisitBankAndDepositGold Instance
        {
            get
            {
                if (instance == null)
                    instance = new VisitBankAndDepositGold();
                return instance;
            }
        }

        private VisitBankAndDepositGold()
        { }

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
