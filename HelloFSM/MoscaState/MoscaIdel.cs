using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class MoscaIdel:StateBase<Mosca>
    {
        public void Enter(Mosca gameEntity)
        {
            throw new NotImplementedException();
        }

        public void Excute(Mosca gameEntity)
        {
            throw new NotImplementedException();
        }

        public void Exit(Mosca gameEntity)
        {
            throw new NotImplementedException();
        }

        public bool OnMessage(Mosca pReceiver, Telegram telegram)
        {
            throw new NotImplementedException();
        }

        public static StateBase<Mosca> Instance { get; set; }
    }
}
