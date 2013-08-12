using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveterDataExtractor
{
    public class MsgHandler
    {

        public MsgHandler()
        {
            

        }


        public string getCmd(int i)
        {

            Msg msg = new Msg();

            if (i < 5)
            {
                msg.Cmd = "True";
            }
            else
            {
                msg.Cmd = "False";
            }



            return msg.Cmd;
        }







    }

    class Msg : EventArgs
    {

        public string Cmd { set; get; }
    }




}
