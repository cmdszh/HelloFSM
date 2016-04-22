using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class EnterMineAndDigForNugget:State<Miner>
    {
        private static EnterMineAndDigForNugget m_kInstance;
        public static EnterMineAndDigForNugget Instance
        {
            get
            {
                if (m_kInstance == null) new EnterMineAndDigForNugget();
                return m_kInstance;
            }
        }

        public void Enter(Miner miner)
        {
            if (miner.Location != 1)//"goldMine"
            {
                miner.changeLocation(1);
            }
        }

        public void Excute(Miner miner)
        {
            miner.AddToGoldCarried(1);
            miner.IncreaseFatigue();
            if (miner.PocketsFull())
            {
                miner.ChangeState(VisitBankAndDepositGold.Instance);
            }

            if (miner.Thirsty())
            {
                miner.ChangeState(QuenchThirst.Instance);
            }
        }

        public void Exit(Miner gameEntity)
        {
            throw new NotImplementedException();
        }
    }
}
