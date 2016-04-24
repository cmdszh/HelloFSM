using HelloFSM.ElsaStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class MinerWife:BaseGameEntity,IDisposable
    {
        private StateMachine<MinerWife> m_kStateMachine;

        public string Name { get; set; }

        public MinerWife(int id):base(id)
        {
            m_kStateMachine = new StateMachine<MinerWife>(this);
            m_kStateMachine.SetCurrentState(DoHouseWork.Instance);
            m_kStateMachine.SetGlobleState(WifesGlobalState.Instance);
        }

        public StateMachine<MinerWife> getFSM()
        {
            return m_kStateMachine;
        }

        public void Dispose()
        {
            m_kStateMachine = null;
        }

        internal bool Cooking()
        {
            throw new NotImplementedException();
        }

        internal void SetCooking(bool p)
        {
            throw new NotImplementedException();
        }
    }
}
