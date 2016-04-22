using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public interface State<T> where T : BaseGameEntity
    {
        void Enter(T gameEntity);

        void Excute(T gameEntity);

        void Exit(T gameEntity);

    }
}
