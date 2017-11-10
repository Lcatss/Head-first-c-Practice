using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable] public enum BeeState
    {
        空闲,
        飞向花朵,
        收集花蜜,
        返回蜂巢,
        制造蜂蜜,
        退休,
    }
}
