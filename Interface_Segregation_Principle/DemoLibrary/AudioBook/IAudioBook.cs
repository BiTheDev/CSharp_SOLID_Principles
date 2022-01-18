using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public interface IAudioBook:ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
