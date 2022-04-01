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


        public int Write(string value, string datatype, string area, int pos, int bit)
        {

            byte[] buffer;
            if (area == "Q")
            {
                if (datatype == "INT")
                {
                    buffer = new byte[2];
                    S7.SetIntAt(buffer, 0, Convert.ToInt16(value));
                    return ABWrite(pos, 2, buffer);
                    //MessageBox.Show(ErrorText(result));
                }
                else if (datatype == "REAL")
                {
                    buffer = new byte[4];
                    S7.SetRealAt(buffer, 0, Convert.ToSingle(value));
                    return ABWrite(pos, 4, buffer);
                }
                else if (datatype == "WORD")
                {
                    buffer = new byte[2];
                    S7.SetWordAt(buffer, 0, Convert.ToUInt16(value));
                    return ABWrite(pos, 4, buffer);
                }
                else if (datatype == "DWORD")
                {
                    buffer = new byte[2];
                    S7.SetWordAt(buffer, 0, Convert.ToUInt16(value));
                    return ABWrite(pos, 4, buffer);
                }
                else
                {
                    return 7;
                }

            }
            else if (area == "M")
            {
                if (datatype == "INT")
                {
                    buffer = new byte[2];
                    S7.SetIntAt(buffer, 0, Convert.ToInt16(value));
                    return MBWrite(pos, 2, buffer);
                    //MessageBox.Show(ErrorText(result));
                }
                else if (datatype == "REAL")
                {
                    buffer = new byte[4];
                    S7.SetRealAt(buffer, 0, Convert.ToSingle(value));
                    return MBWrite(pos, 4, buffer);
                }
                else if (datatype == "WORD")
                {
                    buffer = new byte[2];
                    S7.SetWordAt(buffer, 0, Convert.ToUInt16(value));
                    return MBWrite(pos, 4, buffer);
                }
                else if (datatype == "DWORD")
                {
                    buffer = new byte[2];
                    S7.SetWordAt(buffer, 0, Convert.ToUInt16(value));
                    return MBWrite(pos, 4, buffer);
                }
                else
                {
                    return 7;
                }

            }
            else
            {
                return 7;
            }

        }
        public int Write(bool value, string area, int pos, int bit)
        {
            if (area == "Q")
            {
                byte[] buffer = new byte[1];
                S7.SetBitAt(buffer, 0, bit, value);
                return WriteArea(S7Area.PA, 0, pos * 8 + bit, 1, S7WordLength.Bit, buffer);
            }
            else if (area == "M")
            {
                byte[] buffer = new byte[1];
                S7.SetBitAt(buffer, 0, bit, value);
                return WriteArea(S7Area.PA, 0, pos * 8 + bit, 1, S7WordLength.Bit, buffer);
            }
            else
            {
                return 7;
            }
        }

        public string read(string datatype, string area, int position)
        {
            byte[] buffer;
            int readResult = 0;
            switch (datatype)
            {
                case "INT":
                    buffer = new byte[2];
                    break;
                case "WORD":
                    buffer = new byte[2];
                    break;
                case "DWORD":
                    buffer = new byte[4];
                    break;
                case "REAL":
                    buffer = new byte[4];
                    break;
                default:
                    buffer = new byte[2];
                    break;
            }
            //buffer = new byte[100];

            switch (area)
            {
                case "Q":
                    readResult = ABRead(position, buffer.Length, buffer);
                    break;
                case "I":
                    readResult = EBRead(position, buffer.Length, buffer);
                    break;
                case "M":
                    readResult = MBRead(position, buffer.Length, buffer);
                    break;
            }
            if (readResult == 0)
            {
                switch (datatype)
                {
                    case "INT":
                        return S7.GetIntAt(buffer, 0).ToString();
                    case "REAL":
                        return S7.GetRealAt(buffer, 0).ToString();
                    case "WORD":
                        return S7.GetWordAt(buffer, 0).ToString();
                    case "DWORD":
                        return S7.GetDWordAt(buffer, 0).ToString();
                    default:
                        return "null";
                }
            }
            else
            {
                return ErrorText(readResult);
            }


        }
    }
}
