using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/**

* 作者：IT记事本
* 年份：2016
* 网址：www.itnotepad.cn 
* 说明：VLCUtil字符串非托管操作类

**/
namespace VLCLib
{
    class VLCUtil
    {
        public static IntPtr ReturnIntPtr(byte[][] data, int length)
        {

            IntPtr[] dataIntPtrArr = new IntPtr[length];

            for (int i = 0; i < length; i++)
            {

                dataIntPtrArr[i] = Marshal.AllocHGlobal(data[i].Length * sizeof(byte));

                Marshal.Copy(data[i], 0, dataIntPtrArr[i], data[i].Length);

            }

            IntPtr dataIntPtr = Marshal.AllocHGlobal(length * Marshal.SizeOf(typeof(IntPtr)));

            Marshal.Copy(dataIntPtrArr, 0, dataIntPtr, length);

            return dataIntPtr;

        }
        /// <summary>
        /// 字符串转指针
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static IntPtr StringToPtr(string str)
        {
            byte[] bs = Encoding.UTF8.GetBytes(str);

            List<byte> list = new List<byte>(100);
            list.AddRange(bs);
            list.Add((byte)0);//必须末尾增加0，c语言字符串以0结束，否则文件名乱码

            IntPtr pathPtr = Marshal.AllocHGlobal(list.Count);

            Marshal.Copy(list.ToArray(), 0, pathPtr, list.Count);
            return pathPtr;
        }

    }
}
