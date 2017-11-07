using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class AimModel : Model
{
    public float focus;
    public float curDis;
    public float travel_Vertical;//垂直行程
    public float travel_ForAndBack;
    public float travel_Horizontal;

    internal override void ExecuteNotify(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}
