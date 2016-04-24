using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public class Miner:ActorBase,IDisposable
    {
        #region menmber_data
        private StateMachine<Miner> m_kStateMachine;
        private miner_location_type m_kLocation;
        private int m_iGoldCarried;
        private int m_iMoneyInBank;
        private int m_iThirst;
        private int m_iFatigue;
        public miner_location_type Location
        {
            get { return m_kLocation; }
        }

        public StateMachine<Miner> StateMachine
        {
            get { return m_kStateMachine; }
        }
        #endregion

        #region member function
        public Miner(int id):base(id)
        {
            m_kStateMachine = new StateMachine<Miner>(this);
            m_kStateMachine.SetCurrentState(GoHomeAndSleepTilRestes.Instance);
            m_kStateMachine.SetGlobleState(MinerGlobalState.Instance);
        }

        public void ChangeState(StateBase<Miner> m_pNewState)
        {
        }
        public override void Update()
        {
            m_iThirst += 1;
            m_kStateMachine.Update();
        }

        public void changeLocation(miner_location_type loaction)
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

        public override bool HandleMessage(Telegram msg)
        {
            return m_kStateMachine.HandleMessage(msg);
        }
        #endregion


        public string Name { get; set; }

        internal StateMachine<Miner> getFSM()
        {
            return m_kStateMachine;
        }
    }
}
