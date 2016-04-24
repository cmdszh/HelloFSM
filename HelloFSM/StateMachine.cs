using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
   public class StateMachine<T> where T:BaseGameEntity
   {
       #region member data
       private T m_kOwner;
       private State<T> m_kCurrentState;
       private State<T> m_kGlobleState;
       private State<T> m_kPrivirsState;

       public State<T> CurrentState { get { return m_kCurrentState; } }
       public State<T> PrivioursState { get { return m_kPrivirsState; } }
       public State<T> GloubleState { get { return m_kGlobleState; } }

       #endregion

       #region member function
       public StateMachine(T entity)
       { m_kOwner = entity; }

       public void SetCurrentState(State<T> s){m_kCurrentState =s;}
       public void SetGlobleState(State<T> s){m_kGlobleState =s;}
       public void SetPrivirsState(State<T> s){m_kPrivirsState =s;}

       public void Update()
       {
           if(m_kGlobleState !=null)m_kGlobleState.Excute(m_kOwner);
           if(m_kCurrentState!=null)m_kCurrentState.Excute(m_kOwner);
       }

       public void ChangeState(State<T> pNewState)
       {
           if(pNewState !=null )
           {
                m_kPrivirsState = m_kCurrentState;
               m_kCurrentState.Exit(m_kOwner);
               m_kCurrentState=pNewState;
               m_kCurrentState.Enter(m_kOwner);
           }
       }

       public void RevertToPriviousState()
       {
           ChangeState(m_kPrivirsState);
       }

       public bool isInState(State<T> st){
           return st == m_kCurrentState;
       }

       public bool HandleMessage(Telegram telegram)
       {
           if (m_kCurrentState != null && m_kCurrentState.OnMessage(m_kOwner, telegram))
           {
               return true;
           }

           if (m_kGlobleState != null && m_kGlobleState.OnMessage(m_kOwner, telegram))
           {
               return true;
           }
           return false;
       }
       #endregion

   }
}
