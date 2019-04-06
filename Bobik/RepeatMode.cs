using System;

namespace Bobik
{
    [Flags]
    public enum RepeatMode
    {
        None = 0,
        Horizontal = 1,
        Vertical = 2,
        Both = Horizontal | Vertical
    }
}