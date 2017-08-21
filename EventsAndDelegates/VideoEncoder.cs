using System;
using System.Threading;


namespace EventsAndDelegates
{
    class VideoEncoder
    {
        public string StommeString { get; set; }
        private int _myVar;

        public int MyProperty
        {
            get { return _myVar; }
            set { _myVar = value; }
        }




        // 1 define delegate
        // 2 define an event based on delegate
        // 3 raise this event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }

        }
    }
}
