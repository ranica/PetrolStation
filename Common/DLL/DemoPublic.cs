using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Data;

namespace Common.DLL.Public
{
    public class DemoPublic
    {
        public struct SRECORD
        {
            public byte Sindex;
            public byte Slen;
            public byte Target;
            public byte Action;
            public byte bank;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Ptr;
            public byte Len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] Mask;
            public byte Truncate;
        }

        //标签信息
        public struct TagInfo
        {
            public string type;
            public string uii;
            public string tid;
            public string user;
            public string err;
        }

        public struct Para
        {
            public byte[] uii;
            public byte bank;
            public int addr;
            public int len;
            public byte[] pwd;
            public byte[] writedata;
            public bool withuii;
        }

        public static bool Enabel_flg = false;      //使能标志，确定COM口与RLM连接成功或断开  
        public const string API_Path = "UhfReader_API_HID.dll";//DLL文件放到执行文件相同目录下
        public static IntPtr hCom;                  //COM设备参数

        public static byte flagCrc = 0x05;          //CRC、通信波特率标志; 
        public static byte bQ = 0x03;               //防碰撞操作的Q值 

        public static Thread EPCThread;//识别标签线程
        public static bool LoopEnable = false;

        //用于标签信息的显示
        public static TagInfo tagInfo = new TagInfo();
        public static List<TagInfo> tagList = new List<TagInfo>();
        public static int[] cnt = new int[500];
        public static List<string> uiiList = new List<string>();
        public static double interval = 0.2;


        //代理
        public delegate void TagThread();
        public delegate void AddShow(string txt);



        /******************************************************************************************************************/
        /****************                             API 函数定义开始                                       **************/
        /******************************************************************************************************************/

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //open and connect  
        public static extern int UhfSearchHids(StringBuilder serials);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //open and connect  
        public static extern bool UhfReaderConnect(ref IntPtr hCom, string cPort, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //close and disconnect
        public static extern bool UhfReaderDisconnect(ref IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get status
        public static extern bool UhfGetPaStatus(IntPtr hCom, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get power
        public static extern bool UhfGetPower(IntPtr hCom, byte[] power, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //set power
        public static extern bool UhfSetPower(IntPtr hCom, byte option, byte power, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get fre
        public static extern bool UhfGetFrequency(IntPtr hCom, byte[] fremode, byte[] frebase, byte[] basefre, byte[] channnum, byte[] channspc, byte[] frehop, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //set fre
        public static extern bool UhfSetFrequency(IntPtr hCom, byte fremode, byte frebase, byte[] basefre, byte channnum, byte channspc, byte frehop, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get version
        public static extern bool UhfGetVersion(IntPtr hCom, byte[] serial, byte[] version, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get uid
        public static extern bool UhfGetReaderUID(IntPtr hCom, byte[] uid, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //inventory
        public static extern bool UhfStartInventory(IntPtr hCom, byte flagCrcAnti, byte initQ, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               // Get Received
        public static extern bool UhfReadInventory(IntPtr hCom, byte[] ulen, byte[] Uii);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //stop
        public static extern bool UhfStopOperation(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //inventory single
        public static extern bool UhfInventorySingleTag(IntPtr hCom, byte[] ulen, byte[] Uii, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data
        public static extern bool UhfReadDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] readdata, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //write data
        public static extern bool UhfWriteDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] writedata, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single
        public static extern bool UhfReadDataFromSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] readdata, byte[] Uii, byte[] uiiLen, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //write data single
        public static extern bool UhfWriteDataToSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] writedata, byte[] Uii, byte[] uiiLen, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //erase data
        public static extern bool UhfEraseDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //lock
        public static extern bool UhfLockMemByEPC(IntPtr hCom, byte[] pwd, byte[] lockdata, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //kill
        public static extern bool UhfKillTagByEPC(IntPtr hCom, byte[] pwd, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //mutil write data
        public static extern bool UhfBlockWriteDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] writedata, byte[] error, byte[] status, byte[] writelen, byte[] ruuii, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data for Cnt is zero
        public static extern bool UhfReadMaxDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte[] Uii, byte[] datalen, byte[] readdata, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single for Cnt is zero
        public static extern bool UhfReadMaxDataFromSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte[] datalen, byte[] readdata, byte[] Uii, byte[] uiiLen, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single for Anti Q
        public static extern bool UhfStartReadDataFromMultiTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte option, byte[] playload, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single for Anti Q
        public static extern bool UhfGetDataFromMultiTag(IntPtr hCom, byte[] status, byte[] ufData_len, byte[] ufReadData, byte[] usData_len, byte[] usReadData, byte[] uii, byte[] uiilen);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //erase data single
        public static extern bool UhfEraseDataFromSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //lock single
        public static extern bool UhfLockMemFromSingleTag(IntPtr hCom, byte[] pwd, byte[] lockdata, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //kill single
        public static extern bool UhfKillSingleTag(IntPtr hCom, byte[] pwd, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //mutil write data single
        public static extern bool UhfBlockWriteDataToSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] writedata, byte[] Uii, byte[] uiilen, byte[] status, byte[] error, byte[] writelen, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read register
        public static extern bool UhfGetRegister(IntPtr hCom, int radd, int rlen, byte[] status, byte[] reg, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //write register
        public static extern bool UhfSetRegister(IntPtr hCom, int radd, int rlen, byte[] reg, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //reset register
        public static extern bool UhfResetRegister(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //save register
        public static extern bool UhfSaveRegister(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //add select
        public static extern bool UhfAddFilter(IntPtr hCom, ref SRECORD pSRecord, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //delete select
        public static extern bool UhfDeleteFilterByIndex(IntPtr hCom, byte sindex, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get select
        public static extern bool UhfStartGetFilterByIndex(IntPtr hCom, byte sindex, byte snum, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get select received
        public static extern bool UhfReadFilterByIndex(IntPtr hCom, byte[] status, ref SRECORD pSRecord);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //choose select
        public static extern bool UhfSelectFilterByIndex(IntPtr hCom, byte sindex, byte snum, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //sleep mode
        public static extern bool UhfEnterSleepMode(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //start update
        public static extern bool UhfUpdateInit(ref IntPtr hCom, string cPort, byte[] status, byte[] RN32, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //send inverse
        public static extern bool UhfUpdateSendRN32(IntPtr hCom, byte[] RN32, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //start trans
        public static extern bool UhfUpdateSendSize(IntPtr hCom, byte[] status, byte[] filesize, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //tran package
        public static extern bool UhfUpdateSendData(IntPtr hCom, byte[] status, byte packnum, byte lastpack, int data_len, byte[] trandata, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //end update
        public static extern bool UhfUpdateCommit(IntPtr hCom, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern void UhfCharToCString(byte[] byteinput, StringBuilder stroutput, int len);    //convert byte[] to string 

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern void UhfCStringToChar(StringBuilder strinput, byte[] byteoutput, int len);    //convert string to byte[]

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfBlockWriteEPCToSingleTag(IntPtr hCom, byte[] uAccessPwd, byte uCnt, byte[] uWriteData, byte[] uUii, byte[] uLenUii, byte[] uStatus, byte[] uErrorCode, byte[] uWritedLen, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfBlockWriteEPCByEPC(IntPtr hCom, byte[] uAccessPwd, byte uCnt, byte[] uUii, byte[] uWriteData, byte[] uErrorCode, byte[] uStatus, byte[] uWritedLen, byte[] RuUii, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfSetMultiANT(IntPtr hCom, byte[] AntStatus, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfGetMultiANT(IntPtr hCom, byte[] AntStatus, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfCheckANT(IntPtr hCom, byte[] ANT, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfChooseANT(IntPtr hCom, byte ANT, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfStartInventoryForMultiAnt(IntPtr hCom, byte flagAnti, byte initQ, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfReadInventoryFromMultiAnt(IntPtr hCom, byte[] ANT, byte[] uLenUii, byte[] uUii);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfStartReadDataForMultiAnt(IntPtr hCom, byte[] uAccessPwd, byte uBank, byte[] uPtr, byte uCnt, byte uOption, byte[] uPayLoad, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfGetDataFromMultiAnt(IntPtr hCom, byte[] ANT, byte[] uStatus, byte[] ufData_len, byte[] ufReadData, byte[] usData_len, byte[] usReadData, byte[] uUii, byte[] uLenUii);

        /******************************************************************************************************************/
        /****************                             API 函数定义结束                                       **************/
        /******************************************************************************************************************/



        public static bool CheckDigit(string sString)//判断字符串是否为十六进制数
        {
            int i;

            bool Res = false;

            char[] c = sString.ToUpper().ToCharArray();
            for (i = 0; i < c.Length; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch((c[i]).ToString(), "[0-9]") || System.Text.RegularExpressions.Regex.IsMatch((c[i]).ToString(), "[A-F]"))
                    Res = true;
                else
                {
                    Res = false;
                    break;
                }
            }
            return Res;
        }

        public static bool CheckDecimal(string sString)//判断字符串是否为十进制数
        {
            int i;

            bool Res = false;

            char[] c = sString.ToUpper().ToCharArray();
            for (i = 0; i < c.Length; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch((c[i]).ToString(), "[0-9]"))
                    Res = true;
                else
                {
                    Res = false;
                    break;
                }
            }
            return Res;
        }

        public static string StringAddPlace(string InputStr)
        {
            if (InputStr.Length == 0)
                return "";

            string P_str = "";

            for (int i = 0; i < InputStr.Length / 2; i++)
            {
                P_str += InputStr.Substring(2 * i, 2) + " ";
            }

            return P_str;
        }

        public static void HexStringToBytes(string InputStr, byte[] OutPutByte)
        {
            if (InputStr.Length == 0)
                return;

            for (int strLen = 0; strLen < InputStr.Length / 2; strLen++)
                OutPutByte[strLen] = Convert.ToByte(InputStr.Substring(strLen * 2, 2), 16);
        }

        public static byte HexStringToByte(string InputStr)
        {
            if (InputStr.Length != 2)
                return 0x00;

            return Convert.ToByte(InputStr, 16);
        }

        public static string BytesToHexString(byte[] InPutByte, int ConvertLen)
        {
            string OutPutStr = "";
            try
            {
                for (int i = 0; i < ConvertLen; i++)
                {
                    OutPutStr += Convert.ToString((InPutByte[i] >> 4), 16);
                    OutPutStr += Convert.ToString((InPutByte[i] & 0x0F), 16);
                }
                return OutPutStr.ToUpper();
            }
            catch (Exception)
            {
                return "";
            }
        }


        public static string ByteToHexString(byte InputByte)
        {
            string OutPutStr = "";

            try
            {
                OutPutStr += Convert.ToString((InputByte >> 4), 16);
                OutPutStr += Convert.ToString((InputByte & 0x0F), 16);
                return OutPutStr.ToUpper();
            }
            catch (Exception)
            {
                return "";
            }
        }

        /*
        // 主窗体信息显示处理函数，可选择保留使用
        public static void ShowInfo(UhfReader_DEMO.Main objFrom, string info)   // 显示操作信息
        {
            objFrom.SetInfoText = info;
        }*/

        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// 数据窗口信息显示(循环显示时使用)    Show data on ListView contorl
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        public static DataTable getRows ()
        {
			DataTable result = new DataTable ();

			result.Columns.Add ("c1");
			result.Columns.Add ("c2");
			result.Columns.Add ("c3");
			result.Columns.Add ("c4");
			result.Columns.Add ("c5");
			result.Columns.Add ("c6");
			result.Columns.Add ("c7");
			result.Columns.Add ("c8");
			result.Columns.Add ("c9");
			result.Columns.Add ("c10");

            for (int i = 0; i < tagList.Count; i++)
            {
                result.Rows.Add ((i + 1) + "", tagList[i].type, tagList[i].uii, tagList[i].uii.Length / 2, tagList[i].tid, tagList[i].tid.Length / 2, tagList[i].user, tagList[i].user.Length / 2, tagList[i].err, cnt[i]);
            }

			return result;
        }


        public static void CntToZero()
        {
            for (int i = 0; i < 500; i++)
            {
                cnt[i] = 0;
            }
        }

        public static void AddToTagList(string type, string uii, string tid, string user, string err)
        {
            DemoPublic.tagInfo.type = type;
            DemoPublic.tagInfo.uii = uii;
            DemoPublic.tagInfo.tid = tid;
            DemoPublic.tagInfo.user = user;
            DemoPublic.tagInfo.err = err;

            int index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
            if (index == -1)
            {
                DemoPublic.tagList.Add(DemoPublic.tagInfo);
                int indexs = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
                DemoPublic.cnt[indexs] = 1;
            }
            else
            {
                DemoPublic.cnt[index]++;
            }
        }
        //汉字串转换成16进制字符串（Unicode）
        public static string HanziToUnicodeHexString(string hanziStr)
        {
            byte[] unicodebytes = Encoding.Unicode.GetBytes(hanziStr);

            string unicodehexStr = BytesToHexString(unicodebytes, unicodebytes.Length);

            return unicodehexStr;
        }

        //16进制字符串转换成汉字串（Unicode）
        public static string UnicodeHexStringToHanzi(string unicodehexStr)
        {
            int len = unicodehexStr.Length / 2;

            byte[] output = new byte[len];

            HexStringToBytes(unicodehexStr, output);

            string result = Encoding.Unicode.GetString(output);

            return result;
        }
    }
}
