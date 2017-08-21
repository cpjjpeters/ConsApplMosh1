using System;

namespace EventsAndDelegates
{
    
    
        public class SocialMediaService
        {
            public void OnVideoEncoded(object source, EventArgs e)
            {
                Console.WriteLine("SocialMediaService: creating FB message ;-)");
            }
            
        }
    
}