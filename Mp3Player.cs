using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerApp
{
    class Mp3Player : IDisposable
    {
        public bool Repeat { get; set; }
        public object settings { get; internal set; }

        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");
        

        public void open( string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void play()
        {
            logger.Info("play button has been pressed");

                 
                string command = "play MediaFile";
                if (Repeat) command += "REPEAT";
                mciSendString(command, null, 0, IntPtr.Zero);
               
            
        }

        public void stop()
        {
            logger.Info("stop button has been pressed");
         
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void skip()
        {
            logger.Info("skip button has been pressed");

            string command = "skip to the end or next MediaFile";
            if (Repeat) command += "REPEAT";
            mciSendString(command, null, -1, IntPtr.Zero);
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallBack);

        public void Dispose()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
