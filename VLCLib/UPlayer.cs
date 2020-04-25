using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**

* 作者：IT记事本
* 年份：2016
* 网址：www.itnotepad.cn 
* 说明：UPlayer 封装了基于Panel的播放器用户控件

**/
namespace VLCLib
{
    /// <summary>
    /// 播放器用户控件
    /// </summary>
    public class UPlayer : Panel
    {
        public VLCPlayer vlcPlayer = null;//vlc播放器
        bool isInited = false;
        public UPlayer()
        {
            this.Init();
        }

        /// <summary>
        /// 初始化 
        /// </summary>
        /// <returns></returns>
        public void Init()
        {
            try
            {
                vlcPlayer = new VLCPlayer();
                isInited = true;
            }
            catch
            { }
        }
        /// <summary>
        /// 判断是否初始化 成功 
        /// </summary>
        public bool Inited {
            get {
                return this.isInited;
            }
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        public void Stop()
        {
            try
            {
                if (vlcPlayer != null)
                    vlcPlayer.Stop();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="savePath">完成保存路径</param>
        /// <returns></returns>
        private int SnapShot(string savePath)
        {
            int result = -1;
            try
            {
                if (vlcPlayer != null)
                {
                    result = vlcPlayer.SnapShot(savePath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }

        /// <summary>
        /// 播放
        /// </summary>
        public bool Play(string rtsp, IntPtr handle)
        {
            bool flag = false;
            try
            {
                if (vlcPlayer != null)
                {
                    flag = vlcPlayer.Play(rtsp, handle);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public void FullScreen(bool fullScreen)
        {
            vlcPlayer.SetFullScreen(fullScreen);
        }

        
    }
}
