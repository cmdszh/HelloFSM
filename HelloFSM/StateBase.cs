using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public interface StateBase<T> where T : ActorBase
    {
        void Enter(T gameEntity);

        void Excute(T gameEntity);

        void Exit(T gameEntity);

        bool OnMessage(T pReceiver, Telegram telegram);

    }
}
