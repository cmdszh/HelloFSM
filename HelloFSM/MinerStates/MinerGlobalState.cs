﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class MinerGlobalState:StateBase<Miner>
    {
        public static StateBase<Miner> Instance { get; set; }

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
