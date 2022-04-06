using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Sharp7;

namespace Sharp7Form2
{
    public class S7Driver
    {
        private Sharp7Client mClient = new Sharp7Client();
        public Sharp7Client client
        {
            get { return mClient; }
        }
    }
}
