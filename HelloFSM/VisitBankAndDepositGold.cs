using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    class VisitBankAndDepositGold:State<Miner>
    {
        public static State<Miner> Instance { get; set; }

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
    }
}
