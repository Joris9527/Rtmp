using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;


/**

* 作者：IT记事本
* 年份：2016
* 网址：www.itnotepad.cn 
* 说明：VLCAPI封装了libvlc相关API接口 

**/

namespace VLCLib
{
    internal class VLCAPI
    {
        /// <summary>
        /// 新开一个实例
        /// </summary>
        /// <param name="argc"></param>
        /// <param name="argv"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr libvlc_new(int argc, IntPtr argv);

        /// <summary>
        /// 释放
        /// </summary>
        /// <param name="libvlc_instance"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_release(IntPtr libvlc_instance);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern String libvlc_get_version();

        /// <summary>
        /// 从视频来源(例如Url)构建一个libvlc_meida   RTSP
        /// </summary>
        /// <param name="libvlc_instance"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr libvlc_media_new_location(IntPtr libvlc_instance, IntPtr path);

        // 从本地文件路径构建一个libvlc_media   rtsp串流不适合调用此接口
        // [MarshalAs(UnmanagedType.LPStr)] string  path
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr libvlc_media_new_path(IntPtr libvlc_instance, IntPtr  path);

        /// <summary>
        /// 影片长度
        /// </summary>
        /// <param name="libvlc_instance"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr libvlc_media_player_get_length(IntPtr libvlc_media_player);

        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_release(IntPtr libvlc_media_inst);

        /// <summary>
        /// 创建libvlc_media_player(播放核心)
        /// </summary>
        /// <param name="libvlc_instance"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern IntPtr libvlc_media_player_new(IntPtr libvlc_instance);

        /// <summary>
        /// 将视频(libvlc_media)绑定到播放器上
        /// </summary>
        /// <param name="libvlc_media_player"></param>
        /// <param name="libvlc_media"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_set_media(IntPtr libvlc_media_player, IntPtr libvlc_media);


        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_new_from_media(IntPtr libvlc_media_player);

        /// <summary>
        /// 设置图像输出的容器(一般弄个panel)
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        /// <param name="drawable"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_set_hwnd(IntPtr libvlc_mediaplayer, Int32 drawable);



        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_play(IntPtr libvlc_mediaplayer);


        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_pause(IntPtr libvlc_mediaplayer);


        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_stop(IntPtr libvlc_mediaplayer);



        /// <summary>
        /// 解析视频资源的媒体信息(如时长等)
        /// </summary>
        /// <param name="libvlc_media"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_parse(IntPtr libvlc_media);



        /// <summary>
        /// 返回视频的时长(必须先调用libvlc_media_parse之后，该函数才会生效)
        /// </summary>
        /// <param name="libvlc_media"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern Int64 libvlc_media_get_duration(IntPtr libvlc_media);



        /// <summary>
        /// 获取当前播放时间
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern Int64 libvlc_media_player_get_time(IntPtr libvlc_mediaplayer);
        

        /// <summary>
        /// 设置播放位置(拖动)
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        /// <param name="time"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl,  ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_set_time(IntPtr libvlc_mediaplayer, Int64 time);

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        /// <param name="num">经典0</param>
        /// <param name="filePath">完整路径，文件名英文或下划线开头</param>
        /// <param name="i_width"></param>
        /// <param name="i_height"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl,  ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int libvlc_video_take_snapshot(IntPtr libvlc_mediaplayer, uint num ,IntPtr filePath,uint i_width,uint i_height);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="libvlc_mediaplayer"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_media_player_release(IntPtr libvlc_mediaplayer);


        /// <summary>
        /// 获取音量
        /// </summary>
        /// <param name="libvlc_media_player"></param>
        /// <returns></returns>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int libvlc_audio_get_volume(IntPtr libvlc_media_player);


        /// <summary>
        /// 设置音量
        /// </summary>
        /// <param name="libvlc_media_player"></param>
        /// <param name="volume"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_audio_set_volume(IntPtr libvlc_media_player, int volume);


        /// <summary>
        /// 设置全屏
        /// </summary>
        /// <param name="libvlc_media_player"></param>
        /// <param name="isFullScreen"></param>
        [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void libvlc_set_fullscreen(IntPtr libvlc_media_player, int isFullScreen);

    }
}
