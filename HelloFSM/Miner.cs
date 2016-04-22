using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class Miner:BaseGameEntity,IDisposable
    {
        private StateMachine<Miner> m_kStateMachine;
        private State<Miner> m_pCurrentState;
        private State<Miner> m_pGlobalState;
        private State<Miner> m_pPriviousState;
        private int m_kLocation;
        private int m_iGoldCarried;
        private int m_iMoneyInBank;
        private int m_iThirst;
        private int m_iFatigue;

        public Miner(int id):base(id)
        {
            m_kStateMachine = new StateMachine<Miner>(this);
            m_kStateMachine.SetCurrentState(GoHomeAndSleepTilRestes.Instance);
            m_kStateMachine.SetGlobleState(MinerGlobalState.Instance);
        }

        public void RevertToPreviousState()
        {

        }

        public void ChangeState(State<Miner> m_pNewState)
        {
            if (m_pCurrentState == null && m_pNewState == null) return;
            m_pCurrentState.Exit(this);
            m_pCurrentState = m_pNewState;
            m_pCurrentState.Enter(this);

        }
        public override void Update()
        {
            m_iThirst += 1;
            if (m_pCurrentState != null)
            {
                m_pCurrentState.Excute(this);
            }
        }

        public int Location
        {
            get { return m_kLocation; }
        }

        public void changeLocation(int loaction)
        {
            m_kLocation = loaction;
        }

        internal void AddToGoldCarried(int p)
        {
            m_iGoldCarried += 1;
        }

        internal void IncreaseFatigue()
        {
            m_iFatigue += 1;
        }

        internal bool PocketsFull()
        {
           return m_iGoldCarried >= 5;
        }

        internal bool Thirsty()
        {
            return m_iThirst > 10;
        }


        public void Dispose()
        {
            m_kStateMachine = null;
        }

    }
}
