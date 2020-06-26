using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AudioPlayerApp.UnitTests
{
    [TestClass]
    public class Mp3PlayerTest
    {
        [TestMethod]
        public void open_FileNotFound_ExpectedBehavior()
        {
            // Arange
            var mp3player = new Mp3player();


            //Assert
           
        }
        private static void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);

        }

        private class Mp3player
        {
            public Mp3player()
            {
            }
        }
    }
}
