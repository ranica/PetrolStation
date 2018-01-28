using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace Common.DLL.Public
{
	public class PublicFunction
	{
		public delegate void DataReadEvent (object data);
		public static event DataReadEvent onDataRead;

		/// /////////////////////////////////////////////////////////////////
		/// 选择通信波特率    Select baud and crc
		/// 参数说明：
		///     [in]:
		///             long lBaud, 波特率，取值范围为：9600/19200/57600/115200/750000
		///                         作用：选择通信波特率
		///             byte bCrc,  Crc校验，取值范围为：0/1（0：不是用CRC；1：使用CRC）
		/// 
		///     [out]: 无
		/// 
		///     return: bRes
		/// 
		/// ////////////////////////////////////////////////////////////////
		public static void SelectBaudAndCrc(long lBaud, byte bCrc)
		{
			byte bRes = 0x04;
			if (lBaud == 9600)
				bRes = 0x00;
			else if (lBaud == 19200)
				bRes = 0x02;
			else if (lBaud == 57600)
				bRes = 0x04;
			else
				bRes = 0x06;

			if (bCrc != 0)
				bRes = (byte)(bRes | 0x01);

			DemoPublic.flagCrc = bRes;
		}

		/// /////////////////////////////////////////////////////////////////
		/// 连接命令  Connect Function
		/// 参数说明：
		///     
		///     [in]: 
		///             string sPort，串口号（如COM1/COM2等）
		///                            
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// /////////////////////////////////////////////////////////////////
		public static bool ConnectRLM(string sPort)
		{
			return DemoPublic.UhfReaderConnect(ref Public.DemoPublic.hCom, sPort, DemoPublic.flagCrc);
		}

		/// //////////////////////////////////////////////////////////////////
		/// 断开连接命令   DisConnect Function
		/// 参数说明：
		///     
		///     [in]:无
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// /////////////////////////////////////////////////////////////////
		public static bool DisConnectRLM()
		{
			return DemoPublic.UhfReaderDisconnect(ref Public.DemoPublic.hCom, DemoPublic.flagCrc);
		}

		/// /////////////////////////////////////////////////////////////////
		/// 询问连接状态   Get the RLM Status of connect
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// /////////////////////////////////////////////////////////////////
		public static bool GetConnectStatus()
		{
			byte[] bStatus = new byte[1];
			return DemoPublic.UhfGetPaStatus(DemoPublic.hCom, bStatus, DemoPublic.flagCrc);
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取当前输出功率   Get the Power
		/// 参数说明：
		///     
		///     [in]: 无 
		/// 
		///     [out]: byte[] bAPower，输出功率
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool GetPower(byte[] bPower)
		{
			if (DemoPublic.UhfGetPower(DemoPublic.hCom, bPower, DemoPublic.flagCrc))
			{
				//DemoPublic.Power = (bAPower[0] & 0x7F);
				return true;
			}
			else
			{
				return false;
			}
		}

		/// //////////////////////////////////////////////////////////////////
		/// 设置输出功率   Set the Power
		/// 参数说明：
		///     
		///     [in]: 
		///             byte bPower, 输出功率，取值范围：10~30，
		///                          作用：设置/改变当前工作输出功率
		/// 
		///     [out]: 无
		/// 
		///     return:true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool SetPower(byte bPower)
		{
			byte bOption = 0x01;

			if (DemoPublic.UhfSetPower(DemoPublic.hCom, bOption, bPower, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取当前工作频率   Get the Frequency
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]:
		///             byte[] FreMode, 频率工作模式，取值范围：0x00~0x04
		///                           对应值：中国标准920-925/中国标准840-845/ETSI标准/定频模式/用户自定义模式
		///             byte[] FreBase, 频率基数，取值范围：0、1
		///                           对应值：0-50KHz,1-125KHz
		///             byte[] bBaseFre, 起始频率，取值范围：840～960
		///                           
		///             byte[] FreChannel, 频道数，取值范围：0～0xFF
		///                              对应值：0～0xFF
		///             byte[] FreSpc,  频道带宽，取值范围：0～15
		///                           对应值：0～15
		///             byte[] FreHop,  频率跳换方式，取值范围：0~2
		///                           对应值：随机跳换/从高往低顺序跳换/从低往高顺序跳换
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool GetFrequency(byte[] bFreMode, byte[] bFreBase, byte[] bBaseFre, byte[] bFreChannel, byte[] bFreSpc, byte[] bFreHop)
		{
			if (DemoPublic.UhfGetFrequency(DemoPublic.hCom, bFreMode, bFreBase, bBaseFre, bFreChannel, bFreSpc, bFreHop, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 设置工作频率   Set the Frequency
		/// 参数说明：
		///     
		///     [in]:        
		///             byte FreMode, 频率工作模式，取值范围：0x00~0x04
		///                           对应值：中国标准920-925/中国标准840-845/ETSI标准/定频模式/用户自定义模式
		///             byte FreBase, 频率基数，取值范围：0、1
		///                           对应值：0-50KHz,1-125KHz
		///             byte[] bBaseFre, 起始频率，取值范围：840～960
		///                           对应值：0～950，该值必须能被【频率基数】整除，即能被50或125整除
		///             byte FreChannel, 频道数，取值范围：0～0xFF
		///                              对应值：0～0xFF
		///             byte FreSpc,  频道带宽，取值范围：0～15
		///                           对应值：0～15
		///             byte FreHop,  频率跳换方式，取值范围：0~2
		///                           对应值：随机跳换/从高往低顺序跳换/从低往高顺序跳换
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool SetFrequency(byte FreMode, byte FreBase, byte[] bBaseFre, byte FreChannel, byte FreSpc, byte FreHop)
		{
			if (DemoPublic.UhfSetFrequency(DemoPublic.hCom, FreMode, FreBase, bBaseFre, FreChannel, FreSpc, FreHop, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 获取设备版本信息   Get the Version
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 
		///             byte[] bSerial，硬件序列号
		///             byte[] bVersion，软件版本号
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool GetVersion(byte[] bSerial, byte[] bVersion)
		{
			if (DemoPublic.UhfGetVersion(DemoPublic.hCom, bSerial, bVersion, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取产品Uid   Read the pruduct uid
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 
		///             byte[] Uid，产品Uid
		///             
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadUID(byte[] Uid)
		{
			if (DemoPublic.UhfGetReaderUID(DemoPublic.hCom, Uid, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 识别标签    Inventory Tags Function
		/// 参数说明：
		///     
		///     [in]: 
		///             byte flgAnti, 防碰撞标志，取值范围：0、1
		///                           对应值：0-单标签循环识别;1-防碰撞识别
		///             byte Q.       防碰撞Q值，取值范围：0～15
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool Inventory(byte flgAnti, byte Q)
		{
			if (DemoPublic.UhfStartInventory(DemoPublic.hCom, flgAnti, Q, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 获取uii             Read uii from the buffer
		/// 参数说明：
		///     
		///     [in]:  
		///             无
		/// 
		///     [out]: 
		///             byte[] uLenUii, uii的字节数
		///             byte[] uUii,    标签的uii
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadInventory(byte[] uLenUii, byte[] uUii)
		{
			if (DemoPublic.UhfReadInventory(DemoPublic.hCom, uLenUii, uUii))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 单步识别标签    Inventory Tags Single Function
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 
		///             byte[] UiiLen, 标签UII长度，数组大小：1个byte
		///             byte[] Uii,    标签UII数据，包含PC值
		/// 
		///     return: true,操作成功; false,操作失败
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool InventorySingle(byte[] UiiLen, byte[] Uii)
		{
			if (DemoPublic.UhfInventorySingleTag(DemoPublic.hCom, UiiLen, Uii, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 获取标签数据线程处理函数    Get data of uii Thread Function
		/// 参数说明：
		///     
		///     Intput: 无
		/// 
		///     Output: 无
		/// 
		///     return: 无
		/// 
		/// //////////////////////////////////////////////////////////////////

		public static void GetUiiThread_Timer(Object obj)
		{
			string Uii_str = "";
			//int i;

			byte[] blen = new byte[1];
			byte[] buii = new byte[255];

			DemoPublic.Para para = (DemoPublic.Para)obj;

			do
			{
				Uii_str = "";

				if (ReadInventory(blen, buii))
				{
					System.Media.SystemSounds.Asterisk.Play();

					Uii_str = DemoPublic.BytesToHexString(buii, blen[0]);

					DemoPublic.tagInfo.type = "Inventory";

					DemoPublic.tagInfo.uii = Uii_str;
					DemoPublic.tagInfo.tid = "";
					DemoPublic.tagInfo.user = "";
					DemoPublic.tagInfo.err = "";

					if (!DemoPublic.uiiList.Contains(Uii_str))
					{
						DemoPublic.uiiList.Add(Uii_str);
					}

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
				else { Console.WriteLine("No tag be found"); }

			} while (DemoPublic.LoopEnable);

			//DemoPublic.TagThread tagThread = new DemoPublic.TagThread(DemoPublic.ShowLoop);
			//DemoPublic.PublicDM.BeginInvoke(tagThread);

			if (DemoPublic.EPCThread != null)
			{
				DemoPublic.EPCThread.Abort();
			}
		}

		/// //////////////////////////////////////////////////////////////////
		/// 停止操作   Stop command
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool Stop()
		{
			if (DemoPublic.UhfStopOperation(DemoPublic.hCom, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取数据   Read data from tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     读取数据长度,单位为:两个字节 = 字(Word)
		///             byte[] uii,   所要进行读取数据操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] readdata, 读取到的数据,数组大小:255个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadData(byte[] Pwd, byte bank, int addr, byte cnt, byte[] uii, byte[] readdata, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfReadDataByEPC(DemoPublic.hCom, Pwd, bank, ptr, cnt, uii, readdata, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 写数据    Write data to tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     读取数据长度,单位为:两个字节 = 字(Word)
		///             byte[] uii,   所要进行读取数据操作的标签UII号,数组大小:255个字节
		///             byte[] writedata, 写入标签的数据,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteData(byte[] Pwd, byte bank, int addr, byte[] uii, byte[] writedata, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfWriteDataByEPC(DemoPublic.hCom, Pwd, bank, ptr, 1, uii, writedata, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 多字节写数据   Write Multi data to tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     读取数据长度,单位为:两个字节 = 字(Word)
		///             byte[] uii,   所要进行读取数据操作的标签UII号,数组大小:255个字节
		///             byte[] writedata, 写入标签的数据,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		///             byte[] status
		///             byte[] uii
		///             byte[] writelen
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteMultiData(byte[] pwd, byte bank, int addr, byte cnt, byte[] Uii, byte[] writedata, byte[] error, byte[] writelen)
		{
			byte[] ruuii = new byte[256];
			byte[] status = new byte[1];
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfBlockWriteDataByEPC(DemoPublic.hCom, pwd, bank, ptr, cnt, Uii, writedata, error, status, writelen, ruuii, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取数据(不指定UII)   Read data single from tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     读取数据长度,单位为:两个字节 = 字(Word)
		/// 
		///     [out]: 
		///             byte[] uii,      读取到数据操的标签UII号,数组大小:255个字节
		///             byte[] uiilen,   返回的Uii数据长度,数组大小: 1个字节
		///             byte[] readdata, 读取到的数据,数组大小:255个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadDataSingle(byte[] Pwd, byte bank, int addr, byte cnt, byte[] uii, byte[] uiilen, byte[] readdata, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfReadDataFromSingleTag(DemoPublic.hCom, Pwd, bank, ptr, cnt, readdata, uii, uiilen, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 写数据(不指定UII)    Write data single to tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     读取数据长度,单位为:两个字节 = 字(Word)
		///             byte[] writedata, 写入标签的数据,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] uii,      所写入数据的标签的UII号,数组大小:255个字节
		///             byte[] uiilen,   返回的Uii数据长度,数组大小: 1个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/true
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteDataSingle(byte[] Pwd, byte bank, int addr, byte[] uii, byte[] uiilen, byte[] writedata, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfWriteDataToSingleTag(DemoPublic.hCom, Pwd, bank, ptr, 1, writedata, uii, uiilen, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 多字节写数据(不指定UII)    Write Multi data single to tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     写入数据长度,单位为:两个字节 = 字(Word)
		///             byte[] writedata, 写入标签的数据,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] uii,      所写入数据的标签的UII号,数组大小:255个字节
		///             byte[] uiilen,   返回的Uii数据长度,数组大小: 1个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		///             byte[] status
		///             byte[] writelen
		/// 
		///     return: true/true
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteMultiDataSingle(byte[] pwd, byte bank, int addr, byte cnt, byte[] writedata, byte[] Uii, byte[] uiilen, byte[] error, byte[] writelen)
		{
			byte[] status = new byte[1];
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfBlockWriteDataToSingleTag(DemoPublic.hCom, pwd, bank, ptr, cnt, writedata, Uii, uiilen, status, error, writelen, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取数据-Cnt为0(指定UII)   Read data for cnt is zero from tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte[] uii,   读取到数据操的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] datalen,  返回的所读取到的数据长度,数组大小: 2个字节
		///             byte[] readdata, 读取到的数据,数组大小:512个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadDataNoCnt(byte[] Pwd, byte bank, int addr, byte[] uii, byte[] datalen, byte[] readdata, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfReadMaxDataByEPC(DemoPublic.hCom, Pwd, bank, ptr, uii, datalen, readdata, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取数据-Cnt为0(不指定UII)   Read data single for cnt is zero from tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		/// 
		///     [out]: 
		///             byte[] uiilen,   返回的uii数据长度，数组大小为1个字节
		///             byte[] uii,      读取到数据操的标签UII号,数组大小:255个字节
		///             byte[] datalen,  返回的所读取到的数据长度,数组大小: 2个字节
		///             byte[] readdata, 读取到的数据,数组大小:512个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadDataSingleNoCnt(byte[] Pwd, byte bank, int addr, byte[] datalen, byte[] readdata, byte[] uii, byte[] uiilen, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfReadMaxDataFromSingleTag(DemoPublic.hCom, Pwd, bank, ptr, datalen, readdata, uii, uiilen, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}
		/// //////////////////////////////////////////////////////////////////
		/// 防碰撞读取数据-(不指定UII)   Read data single for Anti Q
		/// 参数说明：
		///     
		///     [in]: 
		///             无
		/// 
		///     [out]: 
		///             byte[] status,    读取数据的状态：0x00-只读取一级数据，0x01-读取两级数据
		///             byte[] data1_len, 返回的所读取到的1级数据长度,数组大小: 2个字节
		///             byte[] data1,     读取到的1级数据,数组大小:512个字节
		///             byte[] data2_len, 返回的所读取到的2级数据长度,数组大小: 2个字节
		///             byte[] data2,     读取到的2级数据,数组大小:512个字节
		///             byte[] uiilen,   返回的uii数据长度，数组大小为1个字节
		///             byte[] uii,      读取到数据操的标签UII号,数组大小:255个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadDataAntiSingle(byte[] status, byte[] data1_len, byte[] data1, byte[] data2_len, byte[] data2, byte[] uii, byte[] uiilen)
		{
			if (DemoPublic.UhfGetDataFromMultiTag(DemoPublic.hCom, status, data1_len, data1, data2_len, data2, uii, uiilen))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取数据线程处理函数   Read data from tag Thread
		/// 参数说明：
		///     
		///     Intput: 无
		/// 
		///     Output: 无
		/// 
		///     return: 无
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static void ReadDataThread_Timer(Object obj)
		{
			byte[] uiiLen = new byte[1];
			byte[] dataLen = new byte[2];
			byte[] Data = new byte[256];
			byte[] error = new byte[1];
			string uiiStr = "";
			int index = -1;

			DemoPublic.Para para = (DemoPublic.Para)obj;

			byte[] pwd = para.pwd;
			byte[] Uii = para.uii;
			byte bank = para.bank;
			int addr = para.addr;
			bool withuii = para.withuii;

			int uiilen = 2 * ((Uii[0] >> 3) + 1);

			//DemoPublic.TagThread tagThread = new DemoPublic.TagThread(DemoPublic.ShowLoop);
			//DemoPublic.AddShow addShow = new DemoPublic.AddShow(DemoPublic.AddToShow);

			do
			{
				if (withuii)//指定uii
				{
					if (PublicFunction.ReadDataNoCnt(pwd, bank, addr, Uii, dataLen, Data, error))
					{
						System.Media.SystemSounds.Asterisk.Play();

						uiiStr = DemoPublic.BytesToHexString(Uii, uiilen);
						string dataStr = DemoPublic.BytesToHexString(Data, (int)((dataLen[0] << 8) + dataLen[1]));

						if (!DemoPublic.uiiList.Contains(uiiStr))
						{
							DemoPublic.uiiList.Add(uiiStr);
						}
						DemoPublic.tagInfo.type = "Read";
						DemoPublic.tagInfo.uii = uiiStr;

						if (bank == 0x02)
						{
							DemoPublic.tagInfo.tid = dataStr;
							DemoPublic.tagInfo.user = "";
						}
						else
						{
							DemoPublic.tagInfo.tid = "";
							DemoPublic.tagInfo.user = dataStr;
						}
						DemoPublic.tagInfo.err = "";

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						
						onDataRead.Invoke (uiiStr);
						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Read data successfully with specified tag" });
					}
					else
					{
						//读取失败
						uiiStr = DemoPublic.BytesToHexString(Uii, uiilen);
						DemoPublic.tagInfo.type = "Read";

						DemoPublic.tagInfo.uii = uiiStr;
						DemoPublic.tagInfo.tid = "";
						DemoPublic.tagInfo.user = "";
						if (error[0] == 0x03)
						{
							DemoPublic.tagInfo.err = "Out of memory or PC is not supported";
						}
						else if (error[0] == 0x04)
						{
							DemoPublic.tagInfo.err = "The memory has been locked";
						}
						else if (error[0] == 0x0B)
						{
							DemoPublic.tagInfo.err = "Low battery";
						}
						else
						{
							DemoPublic.tagInfo.err = "Other error";
						}

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Fail to read data with specified tag" });
					}
				}
				else //不指定uii
				{
					if (PublicFunction.ReadDataSingleNoCnt(pwd, bank, addr, dataLen, Data, Uii, uiiLen, error))
					{
						System.Media.SystemSounds.Asterisk.Play();

						string dataStr = DemoPublic.BytesToHexString(Data, (int)((dataLen[0] << 8) + dataLen[1]));
						uiiStr = DemoPublic.BytesToHexString(Uii, uiiLen[0]);

						if (!DemoPublic.uiiList.Contains(uiiStr))
						{
							DemoPublic.uiiList.Add(uiiStr);
						}
						DemoPublic.tagInfo.type = "Read";

						DemoPublic.tagInfo.uii = uiiStr;
						if (bank == 0x02)
						{
							DemoPublic.tagInfo.tid = dataStr;
							DemoPublic.tagInfo.user = "";
						}
						else
						{
							DemoPublic.tagInfo.tid = "";
							DemoPublic.tagInfo.user = dataStr;
						}
						DemoPublic.tagInfo.err = "";

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Read data successfully" });
					}
					else
					{   //读取失败
						DemoPublic.tagInfo.type = "Read";
						DemoPublic.tagInfo.uii = uiiStr;
						DemoPublic.tagInfo.tid = "";
						DemoPublic.tagInfo.user = "";
						if (error[0] == 0x03)
						{
							DemoPublic.tagInfo.err = "Out of memory or PC is not supported";
						}
						else if (error[0] == 0x04)
						{
							DemoPublic.tagInfo.err = "The memory has been locked";
						}
						else if (error[0] == 0x0B)
						{
							DemoPublic.tagInfo.err = "Low battery";
						}
						else
						{
							DemoPublic.tagInfo.err = "Other error";
						}

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Fail to read data" });
					}
				}

			} while (DemoPublic.LoopEnable);

			///DemoPublic.PublicDM.BeginInvoke(tagThread);

			if (DemoPublic.EPCThread != null)
			{
				DemoPublic.EPCThread.Abort();
			}
		}

		/// //////////////////////////////////////////////////////////////////
		/// 写入数据线程处理函数   Write data from tag Thread
		/// 参数说明：
		///     
		///     Intput: 无
		/// 
		///     Output: 无
		/// 
		///     return: 无
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static void WriteDataThread_Timer(Object obj)
		{
			byte[] uiiLen = new byte[1];
			byte[] writelen = new byte[2];
			byte[] error = new byte[1];
			string uiiStr = "";
			int index = -1;

			DemoPublic.Para para = (DemoPublic.Para)obj;

			byte[] pwd = para.pwd;
			byte[] Uii = para.uii;
			byte len = (byte)para.len;
			byte[] writedata = para.writedata;

			bool withuii = para.withuii;

			//Console.WriteLine("writedata::" + writedata[0] + " " + writedata[1]);

			int uiilen = 2 * ((Uii[0] >> 3) + 1);

			///DemoPublic.TagThread tagThread = new DemoPublic.TagThread(DemoPublic.ShowLoop);
			///DemoPublic.AddShow addShow = new DemoPublic.AddShow(DemoPublic.AddToShow);

			do
			{
				if (withuii)//指定uii
				{
					if (PublicFunction.WriteMultiData(pwd, 0x03, 0x00, len, Uii, writedata, error, writelen))
					{
						System.Media.SystemSounds.Asterisk.Play();

						uiiStr = DemoPublic.BytesToHexString(Uii, uiilen);
						string dataStr = DemoPublic.BytesToHexString(writedata, 2 * len);

						if (!DemoPublic.uiiList.Contains(uiiStr))
						{
							DemoPublic.uiiList.Add(uiiStr);
						}
						DemoPublic.tagInfo.type = "Write";

						DemoPublic.tagInfo.uii = uiiStr;
						DemoPublic.tagInfo.tid = "";
						DemoPublic.tagInfo.user = dataStr;
						DemoPublic.tagInfo.err = "";

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Write user successfully with specified tag" });
					}
					else
					{
						uiiStr = DemoPublic.BytesToHexString(Uii, uiilen);
						string dataStr = DemoPublic.BytesToHexString(writedata, 2 * len);

						//Console.WriteLine("dataStr=" + dataStr);
						if (!DemoPublic.uiiList.Contains(uiiStr))
						{
							DemoPublic.uiiList.Add(uiiStr);
						}
						DemoPublic.tagInfo.type = "Write";

						DemoPublic.tagInfo.uii = uiiStr;
						DemoPublic.tagInfo.tid = "";
						DemoPublic.tagInfo.user = dataStr;
						if (error[0] == 0x03)
						{
							DemoPublic.tagInfo.err = "Out of memory or PC is not supported";
						}
						else if (error[0] == 0x04)
						{
							DemoPublic.tagInfo.err = "The memory has been locked";
						}
						else if (error[0] == 0x0B)
						{
							DemoPublic.tagInfo.err = "Low battery";
						}
						else
						{
							DemoPublic.tagInfo.err = "Other error";
						}

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Fail to write user with specified tag" });
					}
				}
				else //不指定uii
				{
					if (PublicFunction.WriteMultiDataSingle(pwd, 0x03, 0x00, len, writedata, Uii, uiiLen, error, writelen))
					{
						System.Media.SystemSounds.Asterisk.Play();

						string dataStr = DemoPublic.BytesToHexString(writedata, 2 * len);
						uiiStr = DemoPublic.BytesToHexString(Uii, uiiLen[0]);

						if (!DemoPublic.uiiList.Contains(uiiStr))
						{
							DemoPublic.uiiList.Add(uiiStr);
						}
						DemoPublic.tagInfo.type = "Write";

						DemoPublic.tagInfo.uii = uiiStr;
						DemoPublic.tagInfo.tid = "";
						DemoPublic.tagInfo.user = dataStr;
						DemoPublic.tagInfo.err = "";

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "Write user successfully" });
					}
					else
					{
						string dataStr = DemoPublic.BytesToHexString(writedata, 2 * len);

						DemoPublic.tagInfo.type = "Write";

						DemoPublic.tagInfo.uii = uiiStr;
						DemoPublic.tagInfo.tid = "";
						DemoPublic.tagInfo.user = dataStr;
						if (error[0] == 0x03)
						{
							DemoPublic.tagInfo.err = "Out of memory or PC is not supported";
						}
						else if (error[0] == 0x04)
						{
							DemoPublic.tagInfo.err = "The memory has been locked";
						}
						else if (error[0] == 0x0B)
						{
							DemoPublic.tagInfo.err = "Low battery";
						}
						else
						{
							DemoPublic.tagInfo.err = "Other error";
						}

						index = -1;
						index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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

						///DemoPublic.PublicDM.BeginInvoke(addShow, new object[] { "fail to write user" });
					}
				}

			} while (DemoPublic.LoopEnable);

			///DemoPublic.PublicDM.BeginInvoke(tagThread);

			if (DemoPublic.EPCThread != null)
			{
				DemoPublic.EPCThread.Abort();
			}
		}

		/// //////////////////////////////////////////////////////////////////
		/// 开启防碰撞读数据函数   Start read data from multi tags
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Access密码,默认为全0,数组大小为:4
		///             byte bank1, 存储区,取值范围:0x00/0x01/0x02/0x03,对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             int addr1, 地址指针,即为地址偏移量
		///             byte cnt1, 长度,以Word为单位
		///             byte option, 0-读取1级数据,1-读取2级数据
		///             byte bank2, 存储区,取值范围:0x00/0x01/0x02/0x03,对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             int addr2, 地址指针,即为地址偏移量
		///             byte cnt2, 长度,以Word为单位
		///             byte bQ, Q值
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool StartReadDataFromMultiTag(byte[] AccessPwd, byte bank1, int addr1, byte cnt1, byte option, byte bank2, int addr2, byte cnt2, byte bQ)
		{
			byte bank = bank1;
			byte[] ptr = new byte[2];
			byte cnt = cnt1;
			byte[] payload = new byte[6];
			int ptr_ebv = 0;

			if (addr1 > 127)
			{
				ptr[0] = (byte)((addr1 >> 7) | 0x80);
				ptr[1] = (byte)(addr1 & 0x7F);
			}
			else
			{
				ptr[0] = (byte)(addr1);
			}

			if (option == 1)
			{
				payload[0] = bank2;

				if (addr2 > 127)
				{
					payload[1] = (byte)((addr2 >> 7) | 0x80);
					payload[2] = (byte)(addr2 & 0x7F);
					ptr_ebv = 1;
				}
				else
				{
					payload[1] = (byte)(addr2);
				}

				payload[2 + ptr_ebv] = cnt2;
				payload[3 + ptr_ebv] = bQ;
				payload[4 + ptr_ebv] = 0x20;
			}
			else
			{
				payload[0] = bQ;
				payload[1] = 0x20;
			}

			if (DemoPublic.UhfStartReadDataFromMultiTag(DemoPublic.hCom, AccessPwd, bank, ptr, cnt, option, payload, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 擦除数据    Erase data
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             byte[] ptr,   地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     擦除数据长度,单位为:两个字节 = 字(Word)
		///             byte[] uii,   所要进行擦除数据操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool EraseData(byte[] Pwd, byte bank, int addr, byte cnt, byte[] uii, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfEraseDataByEPC(DemoPublic.hCom, Pwd, bank, ptr, cnt, uii, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}


		/// //////////////////////////////////////////////////////////////////
		/// 擦除数据(不指定UII)    Erase data Single
		/// 参数说明：
		///     
		///     [in]: 
		///             IntPtr[] Pwd, Access密码,默认为全0,数组大小为:4
		///             byte bank,    存储区,取值范围:0x00/0x01/0x02/0x03
		///                           对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             IntPtr[] ptr, 地址指针,即为地址偏移量,该参数为EBV格式,数组大小为:2
		///             byte cnt,     擦除数据长度,单位为:两个字节 = 字(Word)
		///             byte[] uii,   所要进行擦除数据操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool EraseDataSingle(byte[] Pwd, byte bank, int addr, byte cnt, byte[] uii, byte[] error)
		{
			byte[] ptr = new byte[2];

			if (addr > 127)
			{
				ptr[0] = (byte)((addr >> 7) | 0x80);
				ptr[1] = (byte)(addr & 0x7F);
			}
			else
			{
				ptr[0] = (byte)addr;
			}

			if (DemoPublic.UhfEraseDataFromSingleTag(DemoPublic.hCom, Pwd, bank, ptr, cnt, uii, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 锁定操作      Lock operate
		/// 参数说明：
		///     
		///     [in]: 
		///             IntPtr[] Pwd,    Access密码,默认为全0,数组大小为:4
		///             byte[] lockdata, 锁定密码,数组大小为: 6个字节
		///             byte[] uii,      所要进行锁定操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool LockMem(byte[] Pwd, byte[] lockdata, byte[] uii, byte[] error)
		{
			if (DemoPublic.UhfLockMemByEPC(DemoPublic.hCom, Pwd, lockdata, uii, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 锁定操作(不指定UII)      Lock operate single
		/// 参数说明：
		///     
		///     [in]: 
		///             IntPtr[] Pwd,    Access密码,默认为全0,数组大小为:4
		///             byte[] lockdata, 锁定密码,数组大小为: 6个字节
		///             byte[] uii,      所要进行锁定操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool LockMemSingle(byte[] Pwd, byte[] lockdata, byte[] uii, byte[] error)
		{
			if (DemoPublic.UhfLockMemFromSingleTag(DemoPublic.hCom, Pwd, lockdata, uii, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 销毁标签      Kill operate
		/// 参数说明：
		///     
		///     [in]: 
		///             IntPtr[] Pwd,    Access密码,默认为全0,数组大小为:4
		///             byte[] uii,      所要进行销毁操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool KillTag(byte[] Pwd, byte[] uii, byte[] error)
		{
			if (DemoPublic.UhfKillTagByEPC(DemoPublic.hCom, Pwd, uii, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}


		/// //////////////////////////////////////////////////////////////////
		/// 销毁标签(不指定UII)      Kill operate single
		/// 参数说明：
		///     
		///     [in]: 
		///             IntPtr[] Pwd,    Access密码,默认为全0,数组大小为:4
		///             byte[] uii,      所要进行销毁操作的标签UII号,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool KillTagSingle(byte[] Pwd, byte[] uii, byte[] error)
		{
			if (DemoPublic.UhfKillSingleTag(DemoPublic.hCom, Pwd, uii, error, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取寄存器     Read register
		/// 参数说明：
		///     
		///     [in]: 
		///             int address, 所读寄存地址
		///             int len,     所读数据长度,单位为:字节
		/// 
		///     [out]: 
		///             byte[] reg, 寄存器值
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadReg(int address, byte[] reg)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfGetRegister(DemoPublic.hCom, address, 1, bStatus, reg, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 写寄存器     Write register
		/// 参数说明：
		///     
		///     [in]: 
		///             int address, 所读寄存地址
		///             byte[] reg,  数据存储数组
		/// 
		///     [out]: 
		///             byte[] status, 操作状态
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteReg(int address, byte[] reg)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfSetRegister(DemoPublic.hCom, address, 1, reg, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 恢复寄存器默认值     Reset register
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ResetReg()
		{
			if (DemoPublic.UhfResetRegister(DemoPublic.hCom, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 保存当前寄存器设置     Save register
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool SaveReg()
		{
			if (DemoPublic.UhfSaveRegister(DemoPublic.hCom, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 蜂鸣器控制     Beep Control
		/// 参数说明：
		///     
		///     [in]: 
		///             bool OpenClose, true-打开蜂鸣器，false-关闭蜂鸣器
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool SetBeep(bool bOpenClose)
		{
			byte[] bBeep = new byte[1];
			byte[] bStatus = new byte[1];

			if (bOpenClose)
				bBeep[0] = 1;
			else
				bBeep[0] = 0;
			if (DemoPublic.UhfSetRegister(DemoPublic.hCom, 288, 1, bBeep, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 设置Timer     Timer Control
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Time, 
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool SetTimer(byte[] Time)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfSetRegister(DemoPublic.hCom, 289, 2, Time, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 进入sleep模式     Sleep mode
		/// 参数说明：
		///     
		///     [in]: 无
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool EnterSleep()
		{
			if (DemoPublic.UhfEnterSleepMode(DemoPublic.hCom, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 添加Select记录     Add select record
		/// 参数说明：
		///     
		///     [in]: 
		///             SRECORD pSRecord, select参数结构体
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool AddSelect(ref DemoPublic.SRECORD pSRcord)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfAddFilter(DemoPublic.hCom, ref pSRcord, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 删除Select记录     Delete select record
		/// 参数说明：
		///     
		///     [in]: 
		///             byte sindex, select记录序号,取值范围: 1～15
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool DeleteSelect(byte sindex)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfDeleteFilterByIndex(DemoPublic.hCom, sindex, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取Select记录     Get select record
		/// 参数说明：
		///     
		///     [in]: 
		///             byte sindex, select记录序号,取值范围: 1～15
		///             byte snum,   读取的select记录数量
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool StartGetSelect(byte sindex, byte snum)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfStartGetFilterByIndex(DemoPublic.hCom, sindex, snum, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 接收Select记录     Get select record received
		/// 参数说明：
		///     
		///     [in]: 
		///             DemoPublic.SRECORD pSRcord, Select命令记录结构体
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool GetSelectReceived(ref DemoPublic.SRECORD pSRcord, byte[] bStatus)
		{
			if (DemoPublic.UhfReadFilterByIndex(DemoPublic.hCom, bStatus, ref pSRcord))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 选择Select     select select record
		/// 参数说明：
		///     
		///     [in]: 
		///             byte sindex, select记录序号,取值范围: 1～15
		///             byte snum,   选择的select记录数量
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ChooseSelect(byte sindex, byte snum)
		{
			byte[] bStatus = new byte[1];

			if (DemoPublic.UhfSelectFilterByIndex(DemoPublic.hCom, sindex, snum, bStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}
		/*
        /// //////////////////////////////////////////////////////////////////
        /// 通知下位机开始升级操作   Start update operate function
        /// 参数说明：
        ///     
        ///     [in]: 
        ///             string cPort，串口号（如COM1/COM2等）
        /// 
        ///     [out]: 
        ///             byte[] RN, RN值，获取下位机返回的RN32数据
        /// 
        ///     return: ture/false
        ///
        /// ///////////////////////////////////////////////////////////////////
        public static bool StarUpdate(string cPort, byte[] bRN32)
        {
            byte[] bStatus = new byte[1];

            if (DemoPublic.UhfUpdateInit(ref DemoPublic.hCom, cPort, bStatus, bRN32, 0x04))//DemoPublic.flagCrc
                return true;
            else
                return false;
        }

        /// //////////////////////////////////////////////////////////////////
        /// 发送RN32值   Send RN32 function
        /// 参数说明：
        ///     
        ///     [in]: 
        ///             byte[] RN, RN32值
        /// 
        ///     [out]: 无
        /// 
        ///     return: true/false
        ///
        /// ///////////////////////////////////////////////////////////////////
        public static bool SendRN(byte[] RN)
        {
            byte[] bStatus = new byte[1];
            byte[] bReverseRN32 = new byte[4];
            bReverseRN32[0] = (byte)~RN[0];
            bReverseRN32[1] = (byte)~RN[1];
            bReverseRN32[2] = (byte)~RN[2];
            bReverseRN32[3] = (byte)~RN[3];

            if (DemoPublic.UhfUpdateSendRN32(DemoPublic.hCom, bReverseRN32, bStatus, 0x04))
                return true;
            else
                return false;
        }

        /// //////////////////////////////////////////////////////////////////
        /// 准备开始传送文件   Start send file function
        /// 参数说明：
        ///     
        ///     [in]: 
        ///             byte[] FILESIZE, 文件大小
        /// 
        ///     [out]: 无
        /// 
        ///     return: true/false
        ///
        /// ///////////////////////////////////////////////////////////////////
        public static bool StarTrans(byte[] FILESIZE)
        {
            byte[] bStatus = new byte[1];

            if (DemoPublic.UhfUpdateSendSize(Public.DemoPublic.hCom, bStatus, FILESIZE, 0x04))
                return true;
            else
                return false;
        }

        /// //////////////////////////////////////////////////////////////////
        /// 发送数据包   Send Data Package function
        /// 参数说明：
        ///     
        ///     [in]: 
        ///             byte packnum, 数据包序号，取值范围：0～0xFF
        ///                           对应值：0～0xFF
        ///             byte lastpack, 最后一个数据包标志，取值范围：0、1
        ///                            对应值：0-该数据包不是最后一个数据包；1-该数据包为最后一个数据包
        ///             int data_len, 数据包大小，取值范围：1～1024
        ///                           对应值：1～1024
        ///             byte[] data,  数据包数组
        /// 
        ///     [out]: 无
        /// 
        ///     return: ture/false
        ///
        /// ///////////////////////////////////////////////////////////////////
        public static bool TranPackage(byte packnum, byte lastpack, int data_len, byte[] data)
        {
            byte[] bStatus = new byte[1];

            if (DemoPublic.UhfUpdateSendData(Public.DemoPublic.hCom, bStatus, packnum, lastpack, data_len, data, 0x04))
                return true;
            else
                return false;
        }

        /// //////////////////////////////////////////////////////////////////
        /// 升级完成   End the update operate function
        /// 参数说明：
        ///     
        ///     [in]: 无
        /// 
        ///     [out]: 无
        /// 
        ///     return: true/false
        ///
        /// ///////////////////////////////////////////////////////////////////
        public static bool EndUpdate()
        {
            byte[] bStatus = new byte[1];

            if (DemoPublic.UhfUpdateCommit(DemoPublic.hCom, bStatus, 0x04))
                return true;
            else
                return false;
        }

        /// //////////////////////////////////////////////////////////////////
        /// 传送整个数据文件   Send file function
        /// 参数说明：
        ///     
        ///     [in]: 
        ///             string filepath, 文件路径字符串
        /// 
        ///     [out]: 无
        /// 
        ///     return: 无
        ///
        /// ///////////////////////////////////////////////////////////////////
        public static void SendFile(string filepath)
        {
            DemoPublic.Progress_Report = 0;
            int i = 0;
            //byte bStatus;
            long file_byte_size = 0;
            long package_num, lastpack_len;
            byte[] package = new byte[1024];

            if (!File.Exists(filepath))
            {
                MessageBox.Show("文件不存在");
                return;
            }
            FileInfo File_info = new FileInfo(filepath);

            file_byte_size = File_info.Length;//获取文件大小  字节
            package_num = file_byte_size / 1024;//获取完整1024byte数据包个数
            lastpack_len = file_byte_size % 1024;//获取最后一个数据包长度  byte

            DemoPublic.Progress_Size = file_byte_size + 1;

            FileStream filestream = new FileStream(filepath, FileMode.Open);
            BinaryReader BReader = new BinaryReader(filestream);

            for (i = 0; i < package_num; i++)//发送完整数据包
            {
                for (int j = 0; j < 1024; j++)
                {
                    package[j] = BReader.ReadByte();
                    DemoPublic.Progress_Report++;
                }

                if (!TranPackage((byte)i, 0x00, 1024, package))
                    return;
            }

            for (int j = 0; j < lastpack_len; j++)
            {
                package[j] = BReader.ReadByte();

                DemoPublic.Progress_Report++;
            }

            if (!TranPackage((byte)i, 0x01, (int)lastpack_len, package))
                return;
            DemoPublic.Progress_Report++;
        }*/

		/// //////////////////////////////////////////////////////////////////
		/// 字节数组转换成字符串   convert byte[] to string
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] byteinput：待转换的字节数组
		/// 
		///             int len：字节数组的长度
		/// 
		///     [out]: 
		///             string OutputStr: 转换后得到的字符串
		/// 
		///     return: OutputStr: 转换后得到的字符串
		///
		/// ///////////////////////////////////////////////////////////////////
		public static string CharToCString(byte[] byteinput, int len)
		{
			StringBuilder OutputStr = new StringBuilder(1024);

			DemoPublic.UhfCharToCString(byteinput, OutputStr, len);

			return OutputStr.ToString(0, len * 2);
		}

		/// //////////////////////////////////////////////////////////////////
		/// 字符串转换成字节数组   convert string to byte[]
		/// 参数说明：
		///     
		///     [in]: 
		///             string strinput：待转换的字符串
		/// 
		///             byte[] byteoutput：转换后得到的字节数组
		/// 
		///     [out]: 
		///             无
		/// 
		///     return: 无
		///
		/// ///////////////////////////////////////////////////////////////////
		public static void CStringToChar(string strinput, byte[] byteoutput)
		{
			StringBuilder InputStr = new StringBuilder(strinput);

			DemoPublic.UhfCStringToChar(InputStr, byteoutput, InputStr.Length);
		}

		/// //////////////////////////////////////////////////////////////////
		/// 获取串口的数量   get COM count
		/// 参数说明：
		///     
		///     [in]: 无
		///             
		/// 
		///     [out]: 无
		///             
		/// 
		///     return: 无
		///
		/// ///////////////////////////////////////////////////////////////////
		public static int GetComNum()
		{
			int num = 0;
			RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");

			if (keyCom != null)
			{
				string[] sSubKeys = keyCom.GetValueNames();

				num = sSubKeys.Length;
			}

			return num;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 写EPC(不指定UII)    Write EPC to single tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte cnt,     写入EPC数据长度,单位为:两个字节 = 字(Word)
		///             byte[] writedata, 写入标签的数据,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] uii,      所写入数据的标签的UII号,数组大小:255个字节
		///             byte[] uiilen,   返回的Uii数据长度,数组大小: 1个字节
		///             byte[] error,    错误代码,数组大小:1个字节
		///             byte[] status
		///             byte[] writelen
		/// 
		///     return: true/true
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteEPCSingle(byte[] Pwd, byte cnt, byte[] uii, byte[] uiilen, byte[] writedata, byte[] error, byte[] writelen)
		{
			byte[] status = new byte[1];

			if (DemoPublic.UhfBlockWriteEPCToSingleTag(DemoPublic.hCom, Pwd, cnt, writedata, uii, uiilen, status, error, writelen, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 写EPC(指定UII)    Write EPC to tag
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Pwd,   Access密码,默认为全0,数组大小为:4
		///             byte cnt,     写入EPC数据长度,单位为:两个字节 = 字(Word)
		///             byte[] uii,   所要进行读取数据操作的标签UII号,数组大小:255个字节
		///             byte[] writedata, 写入标签的数据,数组大小:255个字节
		/// 
		///     [out]: 
		///             byte[] error,    错误代码,数组大小:1个字节
		///             byte[] status
		///             byte[] ruuii
		///             byte[] writelen
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool WriteEPC(byte[] Pwd, byte cnt, byte[] uii, byte[] writedata, byte[] error, byte[] writelen)
		{
			byte[] ruuii = new byte[256];
			byte[] status = new byte[1];

			if (DemoPublic.UhfBlockWriteEPCByEPC(DemoPublic.hCom, Pwd, cnt, uii, writedata, error, status, writelen, ruuii, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 生成锁定码      Lock Code
		/// 参数说明：
		///     
		///     Intput: 
		///             byte kill,    Kill密码锁定选项
		///             byte access,  Accesss密码锁定选项
		///             byte uii,     UII存储区锁定选项
		///             byte tid,     Tid存储区锁定选项
		///             byte user,    User存储区锁定选项
		/// 
		///     Output: 无       
		/// 
		///     return: true
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static void LockGenCode(byte kill, byte access, byte uii, byte tid, byte user, byte[] lockcode)
		{
			lockcode[0] = 0x00;
			lockcode[1] = 0x00;
			lockcode[2] = 0x00;

			//KillPwd
			if (kill == 1)//锁定
			{
				lockcode[0] |= 0x0c;
				lockcode[1] |= 0x02;
			}
			else if (kill == 2)//解锁
			{
				lockcode[0] |= 0x0c;
				lockcode[1] |= 0x00;
			}
			else if (kill == 3)//永久锁定
			{
				lockcode[0] |= 0x0c;
				lockcode[1] |= 0x03;
			}
			else if (kill == 4)//永久解锁
			{
				lockcode[0] |= 0x0c;
				lockcode[1] |= 0x01;
			}
			else//保持状态
			{
				lockcode[0] &= 0x03;
				lockcode[1] &= 0xfc;
			}

			//AccessPwd
			if (access == 1)//锁定
			{
				lockcode[0] |= 0x03;
				lockcode[2] |= 0x80;
			}
			else if (access == 2)//解锁
			{
				lockcode[0] |= 0x03;
				lockcode[2] |= 0x00;
			}
			else if (access == 3)//永久锁定
			{
				lockcode[0] |= 0x03;
				lockcode[2] |= 0xC0;
			}
			else if (access == 4)//永久解锁
			{
				lockcode[0] |= 0x03;
				lockcode[2] |= 0x40;
			}
			else//保持状态
			{
				lockcode[0] &= 0x0c;
				lockcode[2] &= 0x3f;
			}

			//UII
			if (uii == 1)//锁定
			{
				lockcode[1] |= 0xc0;
				lockcode[2] |= 0x20;
			}
			else if (uii == 2)//解锁
			{
				lockcode[1] |= 0xc0;
				lockcode[2] |= 0x00;
			}
			else if (uii == 3)//永久锁定
			{
				lockcode[1] |= 0xc0;
				lockcode[2] |= 0x30;
			}
			else if (uii == 4)//永久解锁
			{
				lockcode[1] |= 0xc0;
				lockcode[2] |= 0x10;
			}
			else//保持状态
			{
				lockcode[1] &= 0x3f;
				lockcode[2] &= 0xcf;
			}

			//TID
			if (tid == 1)//锁定
			{
				lockcode[1] |= 0x30;
				lockcode[2] |= 0x08;
			}
			else if (tid == 2)//解锁
			{
				lockcode[1] |= 0x30;
				lockcode[2] |= 0x00;
			}
			else if (tid == 3)//永久锁定
			{
				lockcode[1] |= 0x30;
				lockcode[2] |= 0x0c;
			}
			else if (tid == 4)//永久解锁
			{
				lockcode[1] |= 0x30;
				lockcode[2] |= 0x04;
			}
			else//保持状态
			{
				lockcode[1] &= 0xcf;
				lockcode[2] &= 0xf3;
			}

			if (user == 1)//锁定
			{
				lockcode[1] |= 0x0c;
				lockcode[2] |= 0x02;
			}
			else if (user == 2)//解锁
			{
				lockcode[1] |= 0x0c;
				lockcode[2] |= 0x00;
			}
			else if (user == 3)//永久锁定
			{
				lockcode[1] |= 0x0c;
				lockcode[2] |= 0x03;
			}
			else if (user == 4)//永久解锁
			{
				lockcode[1] |= 0x0c;
				lockcode[2] |= 0x01;
			}
			else//保持状态
			{
				lockcode[1] &= 0xf3;
				lockcode[2] &= 0xfc;
			}
		}

		/// //////////////////////////////////////////////////////////////////
		/// 开启或关闭多天线功能    Open or close multi antennas function
		/// 参数说明：
		///     
		///     [in]: 
		///             byte AntStatus,    开启或关闭选项；0-关闭，1-开启
		/// 
		///     [out]: 
		///             无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool SetMultiANT(byte AntFlag)
		{
			byte[] AntStatus = new byte[1];
			AntStatus[0] = AntFlag;

			if (DemoPublic.UhfSetMultiANT(DemoPublic.hCom, AntStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 读取多天线功能的当前状态    Get status about multi antennas function
		/// 参数说明：
		///     
		///     [in]: 
		///             无
		/// 
		///     [out]: 
		///             byte[] AntStatus,    开启或关闭选项；0-关闭，1-开启
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool GetMultiANT(byte[] AntStatus)
		{
			if (DemoPublic.UhfGetMultiANT(DemoPublic.hCom, AntStatus, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 监测各天线状态    Check status about antennas
		/// 参数说明：
		///     
		///     [in]: 
		///             无
		/// 
		///     [out]: 
		///             byte[] Ants,    各天线端口的状态
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool CheckANT(byte[] Ants)
		{
			if (DemoPublic.UhfCheckANT(DemoPublic.hCom, Ants, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 选择使用多个天线    Choose antennas to use
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Ants,    选择的天线
		/// 
		///     [out]: 
		///             无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ChooseANT(byte Ants)
		{
			if (DemoPublic.UhfChooseANT(DemoPublic.hCom, Ants, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 开启多天线防碰撞识别标签    start to read uii with multi antennas
		/// 参数说明：
		///     
		///     [in]:  
		///             byte initQ,    Q值，取值范围0~15
		/// 
		///     [out]: 
		///             无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool StartInventoryForMultiAnt(byte initQ)
		{
			if (DemoPublic.UhfStartInventoryForMultiAnt(DemoPublic.hCom, 0x01, initQ, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 获取uii             Read uii from the buffer
		/// 参数说明：
		///     
		///     [in]:  
		///             无
		/// 
		///     [out]: 
		///             byte[] Ant,     天线端口 
		///             byte[] uLenUii, uii的字节数
		///             byte[] uUii,    标签的uii
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadInventoryFromMultiAnt(byte[] Ant, byte[] uLenUii, byte[] uUii)
		{
			if (DemoPublic.UhfReadInventoryFromMultiAnt(DemoPublic.hCom, Ant, uLenUii, uUii))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 获取标签数据线程处理函数    Get data of uii Thread Function
		/// 参数说明：
		///     
		///     Intput: 无
		/// 
		///     Output: 无
		/// 
		///     return: 无
		/// 
		/// //////////////////////////////////////////////////////////////////
		/*
        public static void GetUiiWithMultiAntesThread_Timer()
        {
            string Uii_str = "";
            int i;

            byte[] Ant = new byte[1];
            byte[] blen = new byte[1];
            byte[] buii = new byte[255];

            do
            {
                Uii_str = "";

                if (ReadInventoryFromMultiAnt(Ant, blen, buii))
                {
                    for (i = 1; i <= (int)blen[0]; i++)
                    {
                        DemoPublic.TagArray[i] = buii[i - 1];
                        Uii_str += (buii[i - 1] >> 4).ToString("X");
                        Uii_str += (buii[i - 1] & 0x0F).ToString("X");
                    }

                    DemoPublic.tagInfo.type = "识别";
                    DemoPublic.tagInfo.pc = Uii_str.Substring(0, 4);
                    DemoPublic.tagInfo.epc = Uii_str.Substring(4);
                    DemoPublic.tagInfo.bank = "UII";
                    DemoPublic.tagInfo.addr = "1";
                    DemoPublic.tagInfo.len = "" + blen[0];
                    DemoPublic.tagInfo.data = "";
                    DemoPublic.tagInfo.error = "";

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
                else { Console.WriteLine("请将标签置于天线场区"); }

            } while (DemoPublic.LoopEnable);

            DemoPublic.TagThread tagThread = new DemoPublic.TagThread(DemoPublic.ShowLoop);
            DemoPublic.PublicDM.BeginInvoke(tagThread);

            if (DemoPublic.EPCThread != null)
            {
                DemoPublic.EPCThread.Abort();
            }
        }*/

		/// //////////////////////////////////////////////////////////////////
		/// 开启多天线防碰撞读数据   Start to read data With multi antennas
		/// 参数说明：
		///     
		///     [in]: 
		///             byte[] Access密码,默认为全0,数组大小为:4
		///             byte bank1, 存储区,取值范围:0x00/0x01/0x02/0x03,对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             int addr1, 地址指针,即为地址偏移量
		///             byte cnt1, 长度,以Word为单位
		///             byte option, 0-读取1级数据,1-读取2级数据
		///             byte bank2, 存储区,取值范围:0x00/0x01/0x02/0x03,对应值:0x00-Reserved,0x01-UII,0x02-TID,0x03-USER
		///             int addr2, 地址指针,即为地址偏移量
		///             byte cnt2, 长度,以Word为单位
		///             byte bQ, Q值
		/// 
		///     [out]: 无
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool StartReadDataWithMultiAntes(byte[] AccessPwd, byte bank1, int addr1, byte cnt1, byte option, byte bank2, int addr2, byte cnt2, byte bQ)
		{
			byte bank = bank1;
			byte[] ptr = new byte[2];
			byte cnt = cnt1;
			byte[] payload = new byte[6];
			int ptr_ebv = 0;

			if (addr1 > 127)
			{
				ptr[0] = (byte)((addr1 >> 7) | 0x80);
				ptr[1] = (byte)(addr1 & 0x7F);
			}
			else
			{
				ptr[0] = (byte)(addr1);
			}

			if (option == 1)
			{
				payload[0] = bank2;

				if (addr2 > 127)
				{
					payload[1] = (byte)((addr2 >> 7) | 0x80);
					payload[2] = (byte)(addr2 & 0x7F);
					ptr_ebv = 1;
				}
				else
				{
					payload[1] = (byte)(addr2);
				}

				payload[2 + ptr_ebv] = cnt2;
				payload[3 + ptr_ebv] = bQ;
				payload[4 + ptr_ebv] = 0x20;
			}
			else
			{
				payload[0] = bQ;
				payload[1] = 0x20;
			}

			if (DemoPublic.UhfStartReadDataForMultiAnt(DemoPublic.hCom, AccessPwd, bank, ptr, cnt, option, payload, DemoPublic.flagCrc))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 防碰撞读取数据              Read data single for Anti-collision with multi antennas
		/// 参数说明：
		///     
		///     [in]: 
		///             无
		/// 
		///     [out]: 
		///             byte[] status,    读取数据的状态：0x00-只读取一级数据，0x01-读取两级数据
		///             byte[] Ant,       天线端口号
		///             byte[] data1_len, 返回的所读取到的1级数据长度,数组大小: 2个字节
		///             byte[] data1,     读取到的1级数据,数组大小:512个字节
		///             byte[] data2_len, 返回的所读取到的2级数据长度,数组大小: 2个字节
		///             byte[] data2,     读取到的2级数据,数组大小:512个字节
		///             byte[] uiilen,   返回的uii数据长度，数组大小为1个字节
		///             byte[] uii,      读取到数据操的标签UII号,数组大小:255个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static bool ReadDataAntiSingleWithMultiAntes(byte[] status, byte[] Ant, byte[] data1_len, byte[] data1, byte[] data2_len, byte[] data2, byte[] uii, byte[] uiilen)
		{
			if (DemoPublic.UhfGetDataFromMultiAnt(DemoPublic.hCom, Ant, status, data1_len, data1, data2_len, data2, uii, uiilen))
				return true;
			else
				return false;
		}

		/// //////////////////////////////////////////////////////////////////
		/// 多天线读取数据线程处理函数   Read data from tag whit multi antennas Thread
		/// 参数说明：
		///     
		///     Intput: 
		///             Object obj, 存储标签的信息
		/// 
		///     Output: 无
		/// 
		///     return: 无
		/// 
		/// //////////////////////////////////////////////////////////////////
		/*public static void AntiDataThreadWithAnts_Timer(Object obj)
        {
            DemoPublic.AntiPara antipara = (DemoPublic.AntiPara)obj;
            byte[] AccessPwd = antipara.AccessPwd;
            byte bank1 = antipara.bank1;
            int addr1 = antipara.addr1;
            byte cnt1 = antipara.cnt1;
            byte option = antipara.option;
            byte bank2 = antipara.bank2;
            int addr2 = antipara.addr2;
            byte cnt2 = antipara.cnt2;
            byte bQ = antipara.bQ;

            string Uii_str = "";
            byte[] uii = new byte[255];
            byte[] uiiLen = new byte[1];
            byte[] data1 = new byte[512];
            byte[] data1_Len = new byte[2];
            byte[] data2 = new byte[512];
            byte[] data2_Len = new byte[2];
            byte[] status = new byte[1];
            byte[] Ant = new byte[1];
            int index = -1;

            if (!PublicFunction.StartReadDataWithMultiAntes(AccessPwd, bank1, addr1, cnt1, option, bank2, addr2, cnt2, bQ))
            {
                DemoPublic.ShowInfo(DemoPublic.PublicDM, "开启防碰撞识别标签失败");
                return;
            }

            do
            {
                Uii_str = "";

                if (ReadDataAntiSingleWithMultiAntes(status, Ant, data1_Len, data1, data2_Len, data2, uii, uiiLen))
                {
                    int data0_len;

                    if (status[0] == 0x00)
                    {
                        Uii_str = DemoPublic.BytesToHexString(uii, uiiLen[0]);

                        DemoPublic.tagInfo.type = "读取";
                        DemoPublic.tagInfo.pc = Uii_str.Substring(0, 4);
                        DemoPublic.tagInfo.epc = Uii_str.Substring(4);
                        if (bank1 == 0)
                        {
                            DemoPublic.tagInfo.bank = "RESERVED";
                        }
                        else if (bank1 == 1)
                        {
                            DemoPublic.tagInfo.bank = "UII";
                        }
                        else if (bank1 == 2)
                        {
                            DemoPublic.tagInfo.bank = "TID";
                        }
                        else if (bank1 == 3)
                        {
                            DemoPublic.tagInfo.bank = "USER";
                        }

                        DemoPublic.tagInfo.addr = "" + addr1;
                        data0_len = (data1_Len[0] << 8) + data1_Len[1];
                        DemoPublic.tagInfo.len = "" + data0_len;
                        string dataStr1 = DemoPublic.BytesToHexString(data1, data0_len);
                        DemoPublic.tagInfo.data = dataStr1;
                        DemoPublic.tagInfo.error = "";

                        index = -1;
                        index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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
                    else if (status[0] == 0x01)
                    {
                        Uii_str = DemoPublic.BytesToHexString(uii, uiiLen[0]);

                        DemoPublic.tagInfo.type = "读取";
                        DemoPublic.tagInfo.pc = Uii_str.Substring(0, 4);
                        DemoPublic.tagInfo.epc = Uii_str.Substring(4);
                        //1级数据
                        if (bank1 == 0)
                        {
                            DemoPublic.tagInfo.bank = "RESERVED";
                        }
                        else if (bank1 == 1)
                        {
                            DemoPublic.tagInfo.bank = "UII";
                        }
                        else if (bank1 == 2)
                        {
                            DemoPublic.tagInfo.bank = "TID";
                        }
                        else if (bank1 == 3)
                        {
                            DemoPublic.tagInfo.bank = "USER";
                        }

                        DemoPublic.tagInfo.addr = "" + addr1;

                        data0_len = (data1_Len[0] << 8) + data1_Len[1];
                        string dataStr1 = DemoPublic.BytesToHexString(data1, data0_len);
                        DemoPublic.tagInfo.len = "" + data0_len;
                        DemoPublic.tagInfo.data = dataStr1;
                        DemoPublic.tagInfo.error = "";

                        index = -1;
                        index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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
                        //2级数据
                        if (bank2 == 0)
                        {
                            DemoPublic.tagInfo.bank = "RESERVED";
                        }
                        else if (bank2 == 1)
                        {
                            DemoPublic.tagInfo.bank = "UII";
                        }
                        else if (bank2 == 2)
                        {
                            DemoPublic.tagInfo.bank = "TID";
                        }
                        else if (bank2 == 3)
                        {
                            DemoPublic.tagInfo.bank = "USER";
                        }

                        DemoPublic.tagInfo.addr = "" + addr2;

                        data0_len = (data2_Len[0] << 8) + data2_Len[1];
                        dataStr1 = DemoPublic.BytesToHexString(data2, data0_len);
                        DemoPublic.tagInfo.len = "" + data0_len;
                        DemoPublic.tagInfo.data = dataStr1;
                        DemoPublic.tagInfo.error = "";

                        index = -1;
                        index = DemoPublic.tagList.IndexOf(DemoPublic.tagInfo);
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
                }

            } while (DemoPublic.LoopEnable);

            DemoPublic.TagThread tagThread = new DemoPublic.TagThread(DemoPublic.ShowLoop);
            DemoPublic.PublicDM.BeginInvoke(tagThread);

            if (DemoPublic.EPCThread != null)
            {
                DemoPublic.EPCThread.Abort();
            }
        }*/

		/// //////////////////////////////////////////////////////////////////
		/// 防碰撞读取数据              Read data single for Anti-collision with multi antennas
		/// 参数说明：
		///     
		///     [in]: 
		///             无
		/// 
		///     [out]: 
		///             byte[] status,    读取数据的状态：0x00-只读取一级数据，0x01-读取两级数据
		///             byte[] Ant,       天线端口号
		///             byte[] data1_len, 返回的所读取到的1级数据长度,数组大小: 2个字节
		///             byte[] data1,     读取到的1级数据,数组大小:512个字节
		///             byte[] data2_len, 返回的所读取到的2级数据长度,数组大小: 2个字节
		///             byte[] data2,     读取到的2级数据,数组大小:512个字节
		///             byte[] uiilen,   返回的uii数据长度，数组大小为1个字节
		///             byte[] uii,      读取到数据操的标签UII号,数组大小:255个字节
		/// 
		///     return: true/false
		/// 
		/// //////////////////////////////////////////////////////////////////
		public static int SearchHids(ref string[] serials)
		{
			StringBuilder serialStr = new StringBuilder(1024);

			int hidCnt = DemoPublic.UhfSearchHids(serialStr);

			if (hidCnt == 0)
			{
				return 0;
			}
			else
			{
				serials = serialStr.ToString().Split('|');
			}

			return hidCnt;
		}

	}
}
