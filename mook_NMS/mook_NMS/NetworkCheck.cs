using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Net.NetworkInformation;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace mook_NMS
{
    public class NetworkCheck
    {
        public delegate void ErrorEventHandler(int i, int n, bool f);
        public event ErrorEventHandler OnError;
        string ConSql = "";

        string ItemId = "";
        string ItemName = "";
        string ItemIp = "";

        int LogConfig = 0;
        int SoundConfig = 0;

        public int LogConf
        {
            set { LogConfig = value; }
        }

        public int SoundConf
        {
            set { SoundConfig = value; }
        }

        Thread ListThre = null;
        Thread NetCheckThre = null;
        Thread SoundPlayThread = null;

        bool FlagA = false;

        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const int timeout = 120;
        string strLog = "";

        public NetworkCheck()
        {
            string DbPath = Application.StartupPath;
            ConSql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbPath + @"\NMS.accdb;Mode=ReadWrite";
        }

        public void NetCheckRun()
        {
            ListThre = new Thread(NetCheckList);
            ListThre.Start();
        }

        private void NetCheckList()
        {
            strLog = "";
               var Conn = new OleDbConnection(ConSql);
            Conn.Open();

            var Comm = new OleDbCommand("Select N_ItemID, N_ItemName, N_ItemIp from ItemManage order by N_ID DESC", Conn);
            var myRead = Comm.ExecuteReader();

            while (myRead.Read())
            {
                FlagA = false;
                ItemId = myRead[0].ToString();
                ItemName = myRead[1].ToString();
                ItemIp = myRead[2].ToString();

                object[] ob = new object[] { ItemId, ItemName, ItemIp };
                NetCheckThre = new Thread(new ParameterizedThreadStart(NetCheck));
                NetCheckThre.Start(ob);

                while (true)
                {
                    Thread.Sleep(1);
                    if (FlagA == true) break;
                }
            }
            myRead.Close();
            Conn.Close();

            if (LogConfig == 0)
            {
                string fPath = Application.StartupPath + @"\Logs\" + 
                    DateTime.Now.ToString().Replace(":", "").Replace(" ", "") + ".txt";
                StreamWriter sw = new StreamWriter(fPath);
                sw.WriteLine(strLog);
                sw.Close();
            }
            
            ListThre.Abort();
        }

        private void NetCheck(object o)
        {
            object[] ob = (object[])o;
            string ItemId = (string)ob[0];
            string ItemName = (string)ob[1];
            string ItemIp = (string)ob[2];

            Byte[] buffer = Encoding.ASCII.GetBytes(data);
            options.DontFragment = true;

            PingReply reply = pingSender.Send(ItemIp, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                strLog += ItemIp + " : " + DateTime.Now.ToString() + "\t" + reply.Buffer.Length.ToString() + " Bytes\t" +
                    reply.RoundtripTime.ToString() + " ms\t" + reply.Options.Ttl.ToString() + "\n\r";
                OnError(Convert.ToInt32(ItemId.Split('_')[0]), Convert.ToInt32(ItemId.Split('_')[1]), true);
            }
            else
            {
                strLog += ItemIp + " : 실패\n\r";
                OnError(Convert.ToInt32(ItemId.Split('_')[0]), Convert.ToInt32(ItemId.Split('_')[1]), false);

                if (SoundConfig == 0)
                {
                    SoundPlayThread = new Thread(SoundPlayGo);
                    SoundPlayThread.Start();
                }
            }
            FlagA = true;
            Thread.Sleep(1);
            NetCheckThre.Abort();
        }

        private void SoundPlayGo()
        {
            SoundPlay.PlaySoundStart(Application.StartupPath + @"\sound\siren.wav", 
                new System.IntPtr(), SoundPlay.PlaySoundFlags.SND_SYNC);
            SoundPlayThread.Abort();
        }
    }
}
