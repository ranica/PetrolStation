using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace Common.Helper.Antenna
{
	public class MR6100
	{
		#region Fields
		public int BaudRate = 0x1c200;
		public byte ByteSize = 8;
		private const string DLLPATH = "kernel32.dll";
		public int ERR_DEV_INIT_FAIL = 0x7e1;
		public int ERR_EREASE_FAIL = 0x7dd;
		public int ERR_GET_PARA_FAIL = 0x7e5;
		public int ERR_HANDLE_VALUE = 0x7d3;
		public int ERR_LOAD_INI_LOST = 0x7e0;
		public int ERR_LOCK_FAIL = 0x7dc;
		public int ERR_NOTAG_RETURN = 0x7d2;
		public int ERR_OPEN_REGSTER = 0x7df;
		public int ERR_OUT_PARA_LEN = 0x7e4;
		public int ERR_PORT_CLOSE_FAIL = 0x7e3;
		public int ERR_PORT_OPEN_FAIL = 0x7e2;
		public int ERR_PORT_OPENED = 0x7de;
		public int ERR_RDATA_LEN = 0x7d7;
		public int ERR_READ_FAIL = 0x7da;
		public int ERR_SCMND_FAIL = 0x7d9;
		public int ERR_SDATA_FAIL = 0x7d8;
		public int ERR_SET_PARA_FAIL = 0x7e6;
		public int ERR_TCP_LOCK_FAIL = 0x7e7;
		public int ERR_UDATA_ADDRESS = 0x7d6;
		public int ERR_UDATA_LEN = 0x7d4;
		public int ERR_WRITE_FAIL = 0x7db;
		private const uint GENERIC_READ = 0x80000000;
		private const uint GENERIC_WRITE = 0x40000000;
		private int hComm = -1;
		private const int INVALID_HANDLE_VALUE = -1;
		public int len;
		public byte NOPARITY;
		public byte ONESTOPBIT;
		private const int OPEN_EXISTING = 3;
		public bool Opened;
		public byte Parity;
		public static int PortType = 0;
		private const int PURGE_RXABORT = 2;
		private const int PURGE_RXCLEAR = 8;
		private const int PURGE_TXABORT = 1;
		private const int PURGE_TXCLEAR = 4;
		public int RDERR_CMD_ERR = 0x932;
		public int RDERR_ERASE_FAILED = 0x83c;
		public int RDERR_GENERAL_ERR = 0x835;
		public int RDERR_LOCK_FAILED = 0x83b;
		public int RDERR_NO_TAG = 0x838;
		public int RDERR_PAR_GET_FAILED = 0x837;
		public int RDERR_PAR_SET_FAILED = 0x836;
		public int RDERR_READ_FAILED = 0x839;
		public int RDERR_UNDEFINED = 0x933;
		public int RDERR_WRITE_FAILED = 0x83a;
		public int ReadTimeout = 0x7d0;
		public Socket sock;
		public byte StopBits;
		public static int SUCCESS_RETURN = 0x7d1;
		#endregion

		#region Methods
		private int BaudRateLower (int BaudRate)
		{
			int num = BaudRate;
			if (num <= 0x4b00)
			{
			}
			else if ((num == 0x9600) || (num == 0xe100))
			{
			}
			return SUCCESS_RETURN;
		}

		public int BuzzerLEDOFF (int ReaderAddr)
		{
			byte[] buffer3 = new byte[] { 10, 0, 4, 0x23, 0x1b, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, 7, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int BuzzerLEDON (int ReaderAddr)
		{
			byte[] buffer3 = new byte[] { 10, 0, 4, 0x23, 0x1b, 3, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, 7, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int ClearIdBuf (int ReaderAddr)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x44, 0xb1 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		private void ClearReceiveBuf ()
		{
			if (this.hComm != -1)
			{
				PurgeComm (this.hComm, 10);
			}
		}

		private void ClearSendBuf ()
		{
			if (this.hComm != -1)
			{
				PurgeComm (this.hComm, 5);
			}
		}

		public void CloseCommPort ()
		{
			this.SetBaudRate (0xff, 0x1c200);
			if (this.hComm != -1)
			{
				CloseHandle (this.hComm);
			}
		}

		[DllImport ("kernel32.dll")]
		private static extern bool CloseHandle (int hObject);
		[DllImport ("kernel32.dll")]
		private static extern int CreateFile (string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);
		public int EpcInitEpc (int ReaderAddr, byte bit_cnt)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x84, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			buffer[4] = bit_cnt;
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num;
		}

		public int EpcLockTag (int ReaderAddr, byte MemBank)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x44, 0xb1 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num;
		}

		public int EpcMultiTagIdentify (int ReaderAddr, ref byte[,] tag_buf, ref int tag_cnt, ref byte tag_flag)
		{
			int getCount = 0;
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x80, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[3] == 0)
				{
					tag_cnt = buffer2[1];
				}
				else
				{
					tag_cnt = buffer2[2];
				}
				tag_flag = buffer2[0];
				if (tag_cnt > 0)
				{
					this.GetTagData (0xff, ref tag_buf, tag_cnt, ref getCount);
				}
			}
			return num;
		}

		public int EpcRead (int ReaderAddr, byte membank, byte wordptr, byte wordcnt, ref byte[] value)
		{
			byte[] buffer3 = new byte[] { 10, 0, 5, 0x85, 0, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x20];
			buffer[4] = membank;
			buffer[5] = wordptr;
			buffer[6] = wordcnt;
			int num = this.SendAndRcv (buffer, 8, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] != 0)
			{
				return this.ERR_READ_FAIL;
			}
			for (int i = 0; i < (wordcnt * 2); i++)
			{
				value[i] = buffer2[i + 2];
			}
			return SUCCESS_RETURN;
		}

		public int EpcWrite (int ReaderAddr, byte membank, byte wordptr, ushort value)
		{
			byte[] buffer3 = new byte[] { 10, 0, 6, 0x86, 0, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x20];
			buffer[4] = membank;
			buffer[5] = wordptr;
			buffer[6] = (byte)(value >> 8);
			buffer[7] = (byte)value;
			int num = this.SendAndRcv (buffer, 9, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return this.ERR_WRITE_FAIL;
		}

		[DllImport ("kernel32.dll", SetLastError = true)]
		private static extern bool FlushFileBuffers (int hFile);
		public int Gen2KillTag (int ReaderAddr, uint AccPassWord)
		{
			byte[] buffer3 = new byte[] {
			10, 0, 6, 0x83, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0
		 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			buffer[4] = (byte)((AccPassWord >> 0x18) & 0xff);
			buffer[5] = (byte)((AccPassWord >> 0x10) & 0xff);
			buffer[6] = (byte)((AccPassWord >> 8) & 0xff);
			buffer[7] = (byte)AccPassWord;
			int num = this.SendAndRcv (buffer, 9, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num;
		}

		public void Gen2MultiTagInventory (int ReaderAddr)
		{
			byte[] buffer2 = new byte[] { 10, 0, 3, 0x80, 1, 0x73 };
			buffer2[1] = (byte)ReaderAddr;
			byte[] writeBytes = buffer2;

			if (PortType == 0)
			{
				this.ClearSendBuf ();
				this.ClearReceiveBuf ();
				this.Write (writeBytes, 6);
			}
			else
			{
				this.TcpSend (writeBytes, 6);
			}
			Thread.Sleep (6);
		}

		public void Gen2MultiTagInventoryStop (int ReaderAddr)
		{
			byte[] buffer2 = new byte[] { 10, 0, 2, 0x81, 0x74, 0 };
			buffer2[1] = (byte)ReaderAddr;
			byte[] writeBytes = buffer2;
			if (PortType == 0)
			{
				this.ClearSendBuf ();
				this.ClearReceiveBuf ();
				this.Write (writeBytes, 5);
			}
			else
			{
				this.TcpSend (writeBytes, 5);
			}
			Thread.Sleep (6);
		}

		public int Gen2MultiTagRead (int ReaderAddr, byte MembankMask, byte ResWordPtr, byte ResWordCnt, byte EpcWordPtr, byte EpcWordCnt, byte TidWordPtr, byte TidWordCnt, byte UserWordPtr, byte UserWordCnt, ref int ReadCnt)
		{
			byte[] buffer3 = new byte[20];
			buffer3[0] = 10;
			buffer3[1] = (byte)ReaderAddr;
			buffer3[2] = 11;
			buffer3[3] = 0x84;
			buffer3[4] = MembankMask;
			buffer3[5] = ResWordPtr;
			buffer3[6] = ResWordCnt;
			buffer3[7] = EpcWordPtr;
			buffer3[8] = EpcWordCnt;
			buffer3[9] = TidWordPtr;
			buffer3[10] = TidWordCnt;
			buffer3[11] = UserWordPtr;
			buffer3[12] = UserWordCnt;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			int num = this.SendAndRcv (buffer, 14, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				ReadCnt = (int.Parse (buffer2[1].ToString ()) * 0x100) + int.Parse (buffer2[2].ToString ());
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int Gen2MultiTagWrite (int ReaderAddr, int membank, int wordaddr, int wordLen, string strValue, ref int writeCount)
		{
			byte[] buffer = new byte[100];
			byte[] buffer2 = new byte[0x20];
			buffer[0] = 10;
			buffer[1] = (byte)ReaderAddr;
			buffer[2] = (byte)((wordLen * 2) + 5);
			buffer[3] = 0x85;
			buffer[4] = (byte)membank;
			buffer[5] = (byte)wordaddr;
			buffer[6] = (byte)wordLen;
			for (int i = 0; i < (wordLen * 2); i++)
			{
				buffer[i + 7] = Convert.ToByte (strValue.Substring (i * 2, 2), 0x10);
			}
			int num = this.SendAndRcv (buffer, (wordLen * 2) + 8, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				writeCount = Convert.ToInt32 (buffer2[1].ToString (), 10);
				return SUCCESS_RETURN;
			}
			return this.ERR_WRITE_FAIL;
		}

		public int Gen2SecLock (int ReaderAddr, uint AccPassWord, byte Membank, byte Level)
		{
			byte[] buffer3 = new byte[] {
			10, 0, 8, 0x8a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0
		 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			buffer[4] = (byte)((AccPassWord >> 0x18) & 0xff);
			buffer[5] = (byte)((AccPassWord >> 0x10) & 0xff);
			buffer[6] = (byte)((AccPassWord >> 8) & 0xff);
			buffer[7] = (byte)AccPassWord;
			buffer[8] = Membank;
			buffer[9] = Level;
			int num = this.SendAndRcv (buffer, 11, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return this.RDERR_LOCK_FAILED;
		}

		public int Gen2SecRead (int ReaderAddr, uint AccPassWord, byte Membank, byte WordAddr, byte WordCnt, ref byte[] value)
		{
			byte[] buffer3 = new byte[] {
			10, 0, 9, 0x88, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0
		 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			buffer[4] = (byte)((AccPassWord >> 0x18) & 0xff);
			buffer[5] = (byte)((AccPassWord >> 0x10) & 0xff);
			buffer[6] = (byte)((AccPassWord >> 8) & 0xff);
			buffer[7] = (byte)AccPassWord;
			buffer[8] = Membank;
			buffer[9] = WordAddr;
			buffer[10] = WordCnt;
			int num = this.SendAndRcv (buffer, 12, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] != 0)
			{
				return (0x834 + buffer2[0]);
			}
			for (int i = 0; i < (WordCnt * 2); i++)
			{
				value[i] = buffer2[i + 2];
			}
			return SUCCESS_RETURN;
		}

		public int Gen2SecWrite (int ReaderAddr, uint AccPassWord, byte Membank, byte WordAddr, ushort Value)
		{
			byte[] buffer3 = new byte[] {
			10, 0, 10, 0x89, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0
		 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			buffer[4] = (byte)((AccPassWord >> 0x18) & 0xff);
			buffer[5] = (byte)((AccPassWord >> 0x10) & 0xff);
			buffer[6] = (byte)((AccPassWord >> 8) & 0xff);
			buffer[7] = (byte)AccPassWord;
			buffer[8] = Membank;
			buffer[9] = WordAddr;
			buffer[10] = (byte)((Value >> 8) & 0xff);
			buffer[11] = (byte)(Value & 0xff);
			int num = this.SendAndRcv (buffer, 13, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num;
		}

		public int Gen2SelectConfig (int ReaderAddr, int Action, int Membank, int wordAddr, int wordCnt, string[] words)
		{
			byte[] buffer3 = new byte[] {
			10, 0, 9, 0x8f, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0
		 };
			buffer3[1] = (byte)ReaderAddr;
			buffer3[4] = (byte)Action;
			buffer3[5] = (byte)Membank;
			buffer3[8] = (byte)(wordCnt * 0x10);
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			buffer[2] = (byte)(7 + (2 * wordCnt));
			buffer[6] = (byte)(((0x10 * wordAddr) >> 8) & 0xff);
			buffer[7] = (byte)(0x10 * wordAddr);
			for (int i = 0; i < wordCnt; i++)
			{
				buffer[9 + (i * 2)] = Convert.ToByte (words[i].Substring (0, 2), 0x10);
				buffer[10 + (i * 2)] = Convert.ToByte (words[i].Substring (2, 2), 0x10);
			}
			int num = this.SendAndRcv (buffer, 10 + (2 * wordCnt), ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				this.ClearIdBuf (0xff);
				this.ClearReceiveBuf ();
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int GetAnt (int ReaderAddr, ref byte workAnt, ref byte antState)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x2a, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				workAnt = buffer2[1];
				antState = buffer2[2];
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int GetBuzzerLED (int ReaderAddr, ref byte state)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x24, 0x1b, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				state = buffer2[1];
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		[DllImport ("kernel32.dll")]
		private static extern bool GetCommState (int hFile, ref DCB lpDCB);
		[DllImport ("kernel32.dll")]
		private static extern bool GetCommTimeouts (int hFile, ref COMMTIMEOUTS lpCommTimeouts);
		public int GetFastTagMode (int ReaderAddr, ref int mode)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x16, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				mode = buffer2[1];
			}
			return num;
		}

		public int GetFirmwareVersion (int ReaderAddr, ref byte v1, ref byte v2)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x22, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				v1 = buffer2[1];
				v2 = buffer2[2];
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int GetFrequency (int ReaderAddr, ref int freqNum, ref int[] points)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 40, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				freqNum = buffer2[1];
				for (int i = 0; i < (this.len - 3); i++)
				{
					points[i] = buffer2[i + 2];
				}
			}
			return num;
		}

		[DllImport ("kernel32.dll")]
		private static extern uint GetLastError ();
		public int GetMacAddress (int ReaderAddr, ref string strMacAddr)
		{
			int num = 1;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x24, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num2 = 0xb0;
			for (int i = 0; i < 6; i++)
			{
				buffer[4] = (byte)(num2 + i);
				num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
				if (num != SUCCESS_RETURN)
				{
					break;
				}
				strMacAddr = strMacAddr + string.Format ("{0:X2} ", buffer2[1]);
			}
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int GetRf (int ReaderAddr, ref int[] power)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x26, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x10];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] != 0)
			{
				return (0x834 + buffer2[0]);
			}
			for (int i = 0; i < 4; i++)
			{
				power[i] = buffer2[i + 1];
			}
			return SUCCESS_RETURN;
		}

		public int GetSerialNo (int ReaderAddr, ref string strSerialNo)
		{
			int num = 2;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x24, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num2 = 0x10;
			for (int i = 0; i < 6; i++)
			{
				buffer[4] = (byte)(num2 + i);
				num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
				if (num != SUCCESS_RETURN)
				{
					break;
				}
				strSerialNo = strSerialNo + string.Format ("{0:D2} ", buffer2[1]);
			}
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int GetTagData (int ReaderAddr, ref byte[,] tag_data, int tag_cnt, ref int getCount)
		{
			int num2 = 0;
			int num3 = 0;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x41, 0x10, 0xa3 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x800];
		Label_002C:
			num3++;
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] == 0))
			{
				try
				{
					getCount = buffer2[1];
					if (getCount <= 0)
					{
						goto Label_00C3;
					}
					int num4 = (this.len - 3) / getCount;
					for (int i = 0; i < getCount; i++)
					{
						for (int j = 0; j < num4; j++)
						{
							tag_data[num2, j] = buffer2[((i * num4) + j) + 2];
						}
						num2++;
					}
					goto Label_00BC;
				}
				catch
				{
					num2 = 0;
					goto Label_00C3;
				}
			}
			if (num == this.ERR_SCMND_FAIL)
			{
				goto Label_00C3;
			}
		Label_00BC:
			if (num2 < tag_cnt)
			{
				goto Label_002C;
			}
		Label_00C3:
			getCount = num2;
			return num;
		}

		private int GetTagEPC (int ReaderAddr, ref byte[,] tag_data, byte tag_cnt)
		{
			int num;
			byte num2 = 0;
			byte num3 = 0;
			int num4 = 0;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x40, 8, 0xac };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x100];
			do
			{
				num4++;
				num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
				if ((num == SUCCESS_RETURN) && (buffer2[0] == 0))
				{
					num2 = buffer2[1];
					for (int i = 0; i < num2; i++)
					{
						for (int j = 0; j < 14; j++)
						{
							tag_data[num3, j] = buffer2[((i * 14) + j) + 2];
						}
						num3 = (byte)(num3 + 1);
					}
				}
				if (num4 > ((tag_cnt / 8) + 3))
				{
					return this.ERR_UDATA_LEN;
				}
			}
			while (num3 < tag_cnt);
			return num;
		}

		public int GetTcpParameter (int ReaderAddr, ref string strIP, ref string strMark, ref string strGate, ref int nTcpPort)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x2b, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				for (int i = 0; i < 4; i++)
				{
					if (i < 3)
					{
						strIP = strIP + buffer2[1 + i].ToString () + ".";
					}
					else
					{
						strIP = strIP + buffer2[1 + i].ToString ();
					}
				}
				for (int j = 0; j < 4; j++)
				{
					if (j < 3)
					{
						strMark = strMark + buffer2[5 + j].ToString () + ".";
					}
					else
					{
						strMark = strMark + buffer2[5 + j].ToString ();
					}
				}
				for (int k = 0; k < 4; k++)
				{
					if (k < 3)
					{
						strGate = strGate + buffer2[9 + k].ToString () + ".";
					}
					else
					{
						strGate = strGate + buffer2[9 + k].ToString ();
					}
				}
				nTcpPort = (buffer2[14] << 8) | buffer2[13];
			}
			return num;
		}

		public bool isNetWorkConnect (string ip)
		{
			Ping ping = new Ping ();
			return (ping.Send (ip).Status == IPStatus.Success);
		}

		public int IsoLock (int ReaderAddr, byte addr)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x65, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			buffer[4] = addr;
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num;
		}

		public int IsoLockWithID (int ReaderAddr, byte[] byTagID, byte byAddress)
		{
			byte[] buffer3 = new byte[] { 10, 0, 11, 0x69, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			for (int i = 0; i < 8; i++)
			{
				buffer[4 + i] = byTagID[i];
			}
			buffer[12] = byAddress;
			byte[] buffer2 = new byte[0x100];
			int num2 = this.SendAndRcv (buffer, 14, ref this.len, ref buffer2);
			if ((num2 == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num2;
		}

		public int IsoMultiTagIdentify (int ReaderAddr, ref byte[,] tag_buf, ref int tag_cnt, ref int getCount)
		{
			getCount = 0;
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x60, 0x95 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x40];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] != 0)
			{
				return (0x834 + buffer2[0]);
			}
			tag_cnt = buffer2[1];
			if (tag_cnt > 0)
			{
				this.GetTagData (ReaderAddr, ref tag_buf, tag_cnt, ref getCount);
			}
			return SUCCESS_RETURN;
		}

		public int IsoMultiTagRead (int ReaderAddr, int startAddr, ref byte[,] tag_buf, ref int tag_cnt, ref int getCount)
		{
			getCount = 0;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x61, 0, 0x95 };
			buffer3[1] = (byte)ReaderAddr;
			buffer3[4] = (byte)startAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x40];
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] != 0)
			{
				return (0x834 + buffer2[0]);
			}
			tag_cnt = buffer2[1];
			if (tag_cnt > 0)
			{
				this.GetTagData (ReaderAddr, ref tag_buf, tag_cnt, ref getCount);
			}
			return SUCCESS_RETURN;
		}

		public int IsoQueryLock (int ReaderAddr, byte addr, ref byte lstate)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x66, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			buffer[4] = addr;
			lstate = 0;
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				lstate = buffer2[1];
			}
			return num;
		}

		public int IsoQueryLockWithUID (int ReaderAddr, byte[] byTagID, byte addr, ref byte lstate)
		{
			byte[] buffer3 = new byte[] { 10, 0, 11, 0x6a, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			for (int i = 0; i < 8; i++)
			{
				buffer[4 + i] = byTagID[i];
			}
			buffer[12] = addr;
			lstate = 0;
			int num = this.SendAndRcv (buffer, 14, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				lstate = buffer2[1];
			}
			return num;
		}

		public int IsoRead (int ReaderAddr, byte addr, ref byte[] value)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x68, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x10];
			buffer[4] = addr;
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				for (int i = 0; i < 8; i++)
				{
					value[i] = buffer2[i + 2];
				}
			}
			return num;
		}

		public int IsoReadWithID (int ReaderAddr, byte[] byTagID, byte byAddress, ref byte[] byLabelData, ref byte byAntenna)
		{
			byte[] buffer3 = new byte[] { 10, 0, 11, 0x63, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			for (int i = 0; i < 8; i++)
			{
				buffer[4 + i] = byTagID[i];
			}
			buffer[12] = byAddress;
			byte[] buffer2 = new byte[0x100];
			int num2 = this.SendAndRcv (buffer, 14, ref this.len, ref buffer2);
			if (num2 == SUCCESS_RETURN)
			{
				if (buffer2[0] != 0)
				{
					return (0x834 + buffer2[0]);
				}
				byAntenna = buffer2[4];
				for (int j = 0; j < 8; j++)
				{
					byLabelData[j] = buffer2[2 + j];
				}
				byAntenna = buffer2[1];
			}
			return num2;
		}

		public int IsoWrite (int ReaderAddr, byte addr, byte value)
		{
			byte[] buffer3 = new byte[] { 10, 0, 4, 0x62, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			buffer[4] = addr;
			buffer[5] = value;
			int num = this.SendAndRcv (buffer, 7, ref this.len, ref buffer2);
			if ((num == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num;
		}

		public int IsoWriteWithID (int ReaderAddr, byte[] byTagID, byte byAddress, byte byValue)
		{
			byte[] buffer3 = new byte[] { 10, 0, 12, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			for (int i = 0; i < 8; i++)
			{
				buffer[4 + i] = byTagID[i];
			}
			buffer[12] = byAddress;
			buffer[13] = byValue;
			byte[] buffer2 = new byte[0x100];
			int num2 = this.SendAndRcv (buffer, 15, ref this.len, ref buffer2);
			if ((num2 == SUCCESS_RETURN) && (buffer2[0] != 0))
			{
				return (0x834 + buffer2[0]);
			}
			return num2;
		}

		public int OpenCommPort (string port, int nBaud)
		{
			DCB lpDCB = new DCB ();
			COMMTIMEOUTS lpCommTimeouts = new COMMTIMEOUTS ();
			this.hComm = CreateFile (port, 0xc0000000, 0, 0, 3, 0, 0);
			if (this.hComm == -1)
			{
				return this.ERR_OPEN_REGSTER;
			}
			GetCommTimeouts (this.hComm, ref lpCommTimeouts);
			lpCommTimeouts.ReadTotalTimeoutConstant = this.ReadTimeout;
			lpCommTimeouts.ReadTotalTimeoutMultiplier = 0x7d0;
			lpCommTimeouts.WriteTotalTimeoutMultiplier = 0x7d0;
			lpCommTimeouts.WriteTotalTimeoutConstant = 0x7d0;
			SetCommTimeouts (this.hComm, ref lpCommTimeouts);
			GetCommState (this.hComm, ref lpDCB);
			lpDCB.DCBlength = Marshal.SizeOf (lpDCB);
			lpDCB.BaudRate = this.BaudRate;
			lpDCB.flags = 0;
			lpDCB.ByteSize = this.ByteSize;
			lpDCB.StopBits = this.StopBits;
			lpDCB.Parity = this.Parity;
			if (!SetCommState (this.hComm, ref lpDCB))
			{
				return this.ERR_PORT_OPEN_FAIL;
			}
			if (this.SetBaudRate (0xff, nBaud) != SUCCESS_RETURN)
			{
				return this.ERR_PORT_OPEN_FAIL;
			}
			Thread.Sleep (200);
			this.Opened = true;
			PortType = 0;
			return SUCCESS_RETURN;
		}

		[DllImport ("kernel32.dll", SetLastError = true)]
		private static extern bool PurgeComm (int hFile, uint dwFlags);
		public int QueryIDCount (int ReaderAddr, ref byte tagCount)
		{
			tagCount = 0;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x43, 8, 0xac };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				tagCount = (byte)((buffer2[1] * 10) + buffer2[2]);
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		private int Read (ref byte[] bytData, int NumBytes)
		{
			if (this.hComm != -1)
			{
				OVERLAPPED lpOverlapped = new OVERLAPPED ();
				int lpNumberOfBytesRead = 0;
				ReadFile (this.hComm, bytData, NumBytes, ref lpNumberOfBytesRead, ref lpOverlapped);
				return lpNumberOfBytesRead;
			}
			return -1;
		}

		[DllImport ("kernel32.dll")]
		private static extern bool ReadFile (int hFile, byte[] lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);
		public int ResetParameter (int ReaderAddr)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x2f, 5, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				this.BaudRateLower (4);
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int ResetReader (int ReaderAddr)
		{
			byte[] buffer3 = new byte[] { 10, 0, 2, 0x21, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;

			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			int num = this.SendAndRcv (buffer, 5, ref this.len, ref buffer2);

			if (num != SUCCESS_RETURN)
				return num;

			if (buffer2[0] == 0)
			{
				this.BaudRateLower (4);
				return SUCCESS_RETURN;
			}

			return (0x834 + buffer2[0]);
		}

		private int SendAndRcv (byte[] send_buf, int intSize, ref int len, ref byte[] rcv_buf)
		{
			len = 0;
			byte[] bytData = new byte[3];
			byte num = 0;
			for (int i = 0; i < (intSize - 1); i++)
			{
				num = (byte)(num + send_buf[i]);
			}
			num = (byte)(~num + 1);
			send_buf[intSize - 1] = num;
			if (PortType == 0)
			{
				this.ClearSendBuf ();
				this.ClearReceiveBuf ();
				if (this.Write (send_buf, intSize) != intSize)
				{
					return this.ERR_SET_PARA_FAIL;
				}
				if (this.Read (ref bytData, 3) != 3)
				{
					return this.ERR_NOTAG_RETURN;
				}
				if (bytData[0] != 11)
				{
					return this.ERR_RDATA_LEN;
				}
				len = bytData[2];
				if (this.Read (ref rcv_buf, len) != len)
				{
					return this.ERR_RDATA_LEN;
				}
				return SUCCESS_RETURN;
			}
			if (this.TcpSend (send_buf, intSize) != intSize)
			{
				return this.ERR_SCMND_FAIL;
			}
			if (this.TcpReceive (ref bytData, 3) != 3)
			{
				return this.ERR_NOTAG_RETURN;
			}
			if (bytData[0] != 11)
			{
				return this.ERR_RDATA_LEN;
			}
			len = bytData[2];
			if (this.TcpReceive (ref rcv_buf, len) != len)
			{
				return this.ERR_RDATA_LEN;
			}
			return SUCCESS_RETURN;
		}

		public int SetAnt (int ReaderAddr, byte ant)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x29, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			buffer[4] = ant;
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetBaudRate (int ReaderAddr, int usBaudRate)
		{
			int num;
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x20, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			DCB lpDCB = new DCB ();
			switch (usBaudRate)
			{
				case 0x9600:
				case 2:
					num = 0x9600;
					buffer[4] = 2;
					break;

				case 0xe100:
				case 3:
					num = 0xe100;
					buffer[4] = 3;
					break;

				case 0x1c200:
				case 4:
					num = 0x1c200;
					buffer[4] = 4;
					break;

				case 0:
				case 0x2580:
					num = 0x2580;
					buffer[4] = 0;
					break;

				case 1:
				case 0x4b00:
					num = 0x4b00;
					buffer[4] = 1;
					break;

				default:
					return this.ERR_SET_PARA_FAIL;
			}
			int num2 = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num2 != SUCCESS_RETURN)
			{
				return num2;
			}
			if (!GetCommState (this.hComm, ref lpDCB))
			{
				return this.ERR_GET_PARA_FAIL;
			}
			lpDCB.BaudRate = num;
			lpDCB.ByteSize = 8;
			lpDCB.Parity = this.NOPARITY;
			lpDCB.StopBits = this.ONESTOPBIT;
			if (!SetCommState (this.hComm, ref lpDCB))
			{
				return this.ERR_SET_PARA_FAIL;
			}
			return SUCCESS_RETURN;
		}

		[DllImport ("kernel32.dll")]
		private static extern bool SetCommState (int hFile, ref DCB lpDCB);
		[DllImport ("kernel32.dll")]
		private static extern bool SetCommTimeouts (int hFile, ref COMMTIMEOUTS lpCommTimeouts);
		internal void SetDcbFlag (int whichFlag, int setting, DCB dcb)
		{
			uint num;
			setting = setting << whichFlag;
			if ((whichFlag == 4) || (whichFlag == 12))
			{
				num = 3;
			}
			else if (whichFlag == 15)
			{
				num = 0x1ffff;
			}
			else
			{
				num = 1;
			}
			dcb.flags &= ~(num << whichFlag);
			dcb.flags |= (uint)setting;
		}

		public int SetFastTagMode (int ReaderAddr, int mode)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x15, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			buffer3[4] = (byte)mode;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetFrequency (int ReaderAddr, int freqNum, int[] points)
		{
			byte[] buffer;
			if (freqNum != 0)
			{
				buffer = new byte[freqNum + 6];
				buffer[0] = 10;
				buffer[1] = (byte)ReaderAddr;
				buffer[2] = (byte)(freqNum + 3);
				buffer[3] = 0x27;
				buffer[4] = (byte)freqNum;
				for (int i = 0; i < freqNum; i++)
				{
					buffer[i + 5] = (byte)points[i];
				}
			}
			else
			{
				byte[] buffer3 = new byte[] { 10, 0, 4, 0x27, 0, 0, 0 };
				buffer3[1] = (byte)ReaderAddr;
				buffer3[5] = (byte)points[0];
				buffer = buffer3;
				freqNum = 1;
			}
			byte[] buffer2 = new byte[8];
			int num = this.SendAndRcv (buffer, (byte)(freqNum + 6), ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetMacAddress (int ReaderAddr, string[] strMacAddr)
		{
			int num = 1;
			byte[] buffer3 = new byte[] { 10, 0, 4, 0x23, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num2 = 0xb0;
			for (int i = 0; i < 6; i++)
			{
				buffer[4] = (byte)(num2 + i);
				buffer[5] = Convert.ToByte (strMacAddr[i], 0x10);
				num = this.SendAndRcv (buffer, 7, ref this.len, ref buffer2);
				if (num != SUCCESS_RETURN)
				{
					break;
				}
			}
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetOutPort (int ReaderAddr, byte port_num, byte level)
		{
			byte[] buffer3 = new byte[] { 10, 0, 4, 0x2d, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			buffer[4] = port_num;
			buffer[5] = level;
			int num = this.SendAndRcv (buffer, 7, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetRf (int ReaderAddr, int power1, int power2, int power3, int power4)
		{
			byte[] buffer3 = new byte[] { 10, 0, 6, 0x25, 0, 0, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			buffer3[4] = (byte)power1;
			buffer3[5] = (byte)power2;
			buffer3[6] = (byte)power3;
			buffer3[7] = (byte)power4;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			int num = this.SendAndRcv (buffer, 9, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetSerialNo (int ReaderAddr, string[] strSerialNo)
		{
			int num = 2;
			byte[] buffer3 = new byte[] { 10, 0, 4, 0x23, 0, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[8];
			int num2 = 0x10;
			for (int i = 0; i < 6; i++)
			{
				buffer[4] = (byte)(num2 + i);
				buffer[5] = Convert.ToByte (strSerialNo[i], 10);
				num = this.SendAndRcv (buffer, 7, ref this.len, ref buffer2);
				if (num != SUCCESS_RETURN)
				{
					break;
				}
			}
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetTcpParameter (int ReaderAddr, string strIP, string strMark, string strGate, int nTcpPort)
		{
			byte[] buffer3 = new byte[] {
			10, 0, 0x10, 0x2c, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0
		 };
			buffer3[1] = (byte)ReaderAddr;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[0x80];
			strIP = strIP.Trim ();
			strMark = strMark.Trim ();
			strGate = strGate.Trim ();
			string[] strArray = new string[4];
			string[] strArray2 = new string[4];
			string[] strArray3 = new string[4];
			strArray = strIP.Split (new char[] { '.' });
			strArray2 = strMark.Split (new char[] { '.' });
			strArray3 = strGate.Split (new char[] { '.' });
			for (int i = 0; i < 4; i++)
			{
				buffer[4 + i] = byte.Parse (strArray[i]);
				buffer[8 + i] = byte.Parse (strArray2[i]);
				buffer[12 + i] = byte.Parse (strArray3[i]);
			}
			buffer[0x10] = (byte)(nTcpPort & 0xff);
			buffer[0x11] = (byte)((nTcpPort >> 8) & 0xff);
			int num = this.SendAndRcv (buffer, 0x13, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int SetTestMode (int ReaderAddr, int mode)
		{
			byte[] buffer3 = new byte[] { 10, 0, 3, 0x2f, 0, 0 };
			buffer3[1] = (byte)ReaderAddr;
			buffer3[4] = (byte)mode;
			byte[] buffer = buffer3;
			byte[] buffer2 = new byte[6];
			int num = this.SendAndRcv (buffer, 6, ref this.len, ref buffer2);
			if (num != SUCCESS_RETURN)
			{
				return num;
			}
			if (buffer2[0] == 0)
			{
				return SUCCESS_RETURN;
			}
			return (0x834 + buffer2[0]);
		}

		public int TcpCloseConnect ()
		{
			if (this.sock != null)
			{
				this.sock.Close ();
			}
			return SUCCESS_RETURN;
		}

		public int TcpConnectReader (string ip, int port)
		{
			IPEndPoint remoteEP = new IPEndPoint (IPAddress.Parse (ip), port);
			this.sock = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.sock.ReceiveTimeout = 0x3e8;
			this.sock.SendTimeout = 0x3e8;
			try
			{
				this.sock.Connect (remoteEP);
			}
			catch (Exception)
			{
				return 1;
			}
			if (this.sock.Connected)
			{
				PortType = 1;
				return SUCCESS_RETURN;
			}
			return 1;
		}

		private int TcpReceive (ref byte[] rcv_buf, int len)
		{
			if (!this.sock.Connected)
			{
				return 1;
			}
			try
			{
				return this.sock.Receive (rcv_buf, len, SocketFlags.None);
			}
			catch (Exception exception)
			{
				string message = exception.Message;
				return 1;
			}
		}

		private int TcpSend (byte[] send_buf, int len)
		{
			if (!this.sock.Connected)
				return 1;

			try
			{
				return this.sock.Send (send_buf, len, SocketFlags.None);
			}
			catch (Exception exception)
			{
				string message = exception.Message;
				return 0;
			}
		}

		private int Write (byte[] WriteBytes, int intSize)
		{
			if (this.hComm != -1)
			{
				OVERLAPPED lpOverlapped = new OVERLAPPED ();
				int lpNumberOfBytesWritten = 0;
				WriteFile (this.hComm, WriteBytes, intSize, ref lpNumberOfBytesWritten, ref lpOverlapped);
				return lpNumberOfBytesWritten;
			}
			return -1;
		}

		[DllImport ("kernel32.dll")]
		private static extern bool WriteFile (int hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);
		#endregion

		#region Nested Types
		[StructLayout (LayoutKind.Sequential)]
		private struct COMMTIMEOUTS
		{
			public int ReadIntervalTimeout;
			public int ReadTotalTimeoutMultiplier;
			public int ReadTotalTimeoutConstant;
			public int WriteTotalTimeoutMultiplier;
			public int WriteTotalTimeoutConstant;
		}

		[StructLayout (LayoutKind.Sequential)]
		public struct DCB
		{
			public int DCBlength;
			public int BaudRate;
			public uint flags;
			public ushort wReserved;
			public ushort XonLim;
			public ushort XoffLim;
			public byte ByteSize;
			public byte Parity;
			public byte StopBits;
			public byte XonChar;
			public byte XoffChar;
			public byte ErrorChar;
			public byte EofChar;
			public byte EvtChar;
			public ushort wReserved1;
		}

		[StructLayout (LayoutKind.Sequential)]
		private struct OVERLAPPED
		{
			public int Internal;
			public int InternalHigh;
			public int Offset;
			public int OffsetHigh;
			public int hEvent;
		}
		#endregion
	}
}