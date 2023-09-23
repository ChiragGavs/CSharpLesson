using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayThree
{
    internal class MediaConent
    {
        public virtual void StartPlayingContent() { Console.WriteLine("START"); }
        public virtual void StopPlayingContent() { Console.WriteLine("STOP"); }
        public virtual void PausePlayingContent() { Console.WriteLine("Pause"); }
        public virtual void ContinuePlayingContent() { Console.WriteLine("Continue"); }
    }
    internal class AudioContent :MediaConent
    {

    }
    internal class VideoContent :AudioContent
    {

    }
    internal class tester
    {

    }
}
