using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable] public enum BeeState
    {
        Idle,
        FlyingToFlower,
        GatheringNectar,
        ReturningToHive,
        MakingHoney,
        Retired,
    }
}
