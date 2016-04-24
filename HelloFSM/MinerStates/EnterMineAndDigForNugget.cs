using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class EnterMineAndDigForNugget:StateBase<Miner>
    {
        private static EnterMineAndDigForNugget m_kInstance;
        public static EnterMineAndDigForNugget Instance
        {
            get
            {
                if (m_kInstance == null) m_kInstance= new EnterMineAndDigForNugget();
                return m_kInstance;
            }
        }

        private EnterMineAndDigForNugget()
        {

        }

        public void Enter(Miner miner)
        {
            if (miner.Location != miner_location_type.Mine)//"goldMine"
            {
                miner.changeLocation(miner_location_type.Mine);
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


        public bool OnMessage(Miner pReceiver, Telegram telegram)
        {
            throw new NotImplementedException();
        }
    }
}
