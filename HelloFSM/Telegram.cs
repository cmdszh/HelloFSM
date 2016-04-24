using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFSM
{
    public struct Telegram
    {
        public int Sender;
        public int Receiver;
        public int Msg;
        public double DispatchTime;
        public object ExtraInfo;

        public Telegram(double delay,int sender,int recevier,int msg,object extraInfo)
        {
            Sender = sender;
            Receiver = recevier;
            Msg = msg;
            DispatchTime = delay;
            ExtraInfo = extraInfo;
        }
    }
}
