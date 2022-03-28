using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;

namespace Sharp7Form2 
{
    public class Sharp7Client : S7Client

    {

        //#region private field
               //#endregion

        //#region public field
        
        //#endregion
        public async Task<int> AsyncConnectTo(string ip, int rank, int slot)
        {
            int cnnResult = await Task.Run(() => ConnectTo(ip, rank, slot));
            return cnnResult;
        }
        public void Write(string value, string datatype, string area, int pos, int bit)
        {
            byte[] buffer = new byte[100];
            if (area == "Q")
            {
                switch (datatype)
                {
                    default:
                        break;
                    case "INT":

                        S7.SetIntAt(buffer, pos, Convert.ToInt16(value));
                        ABWrite(0, 100, buffer);
                        break;
                }

            }

        }
        

    }
}
