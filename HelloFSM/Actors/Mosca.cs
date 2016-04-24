using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class Mosca : ActorBase, IDisposable
    {
        private StateMachine<Mosca> m_kStateMachine;

        public StateMachine<Mosca> GetFSM()
        { return m_kStateMachine; }

        public Mosca(int id)
            : base(id)
        {
            m_kStateMachine = new StateMachine<Mosca>(this);
            m_kStateMachine.SetCurrentState(MoscaIdel.Instance);
            m_kStateMachine.SetGlobleState(MoscaGlobalState.Inatance);
        }

        public void Dispose()
        {
            m_kStateMachine = null;
        }
    }
}
