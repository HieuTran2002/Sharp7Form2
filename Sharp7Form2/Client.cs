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
    public class Client
    {
        private Sharp7Client mClient = new Sharp7Client();
        public Sharp7Client client
        {
            get { return mClient; }
        }

        #region connect
        public async Task<int> AsyncConnectTo(string ip, int rank, int slot)
        {
            int cnnResult = await Task.Run(() => mClient.ConnectTo(ip, rank, slot));
            return cnnResult;
        }
        #endregion

        public void Write(string value, string datatype, string area, int pos, int bit)
        {
            
            int result;
            byte[] buffer;
            int size;
            if (area == "Q")
            {
                if (datatype == "INT")
                {
                    buffer = new byte[2];
                    S7.SetIntAt(buffer, 0, Convert.ToInt16(value));
                    result = mClient.ABWrite(pos, 2, buffer);
                        //MessageBox.Show(mClient.ErrorText(result));
                }
                else if (datatype == "REAL")
                {
                    buffer = new byte[4];
                    S7.SetRealAt(buffer, 0, Convert.ToSingle(value));
                    result = mClient.ABWrite(pos, 4, buffer);
                }
                else if (datatype == "WORD")
                {
                    buffer = new byte[2];
                    S7.SetWordAt(buffer, 0, Convert.ToUInt16(value));
                    result = mClient.ABWrite(pos, 4, buffer);
                }  
                else if (datatype == "DWORD")
                {
                    buffer = new byte[2];
                    S7.SetWordAt(buffer, 0, Convert.ToUInt16(value));
                    result = mClient.ABWrite(pos, 4, buffer);
                }
                            
            }                    
        }
        public void Write(bool value, string area, int pos, int bit)
        {
            if (area == "Q")
            {
                byte[] buffer = new byte[1];
                S7.SetBitAt(buffer, 0, bit, value);
                mClient.WriteArea(S7Area.PA, 0, pos*8 + bit, 1, S7WordLength.Bit, buffer);
            }
        }
    }
}
