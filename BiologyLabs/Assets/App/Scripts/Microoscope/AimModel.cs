using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class AimModel : Model
{
    public float focus;
    public float curDis;
    public float travel_Vertical;   //垂直行程
    public float travel_ForAndBack;
    public float travel_Horizontal;
    
    public AimModel()
    {
        RegisterModel(this);
    }
    public void Init()
    {

    }
    public float GetAimRadius()
    {
        if (travel_Vertical == 0) return -1;
        return Math.Abs(focus - curDis * 1000) / travel_Vertical * 1000f;
    }
    public void GetCurDis(Vector3 p1,Vector3 p2)
    {
        curDis = Vector3.Distance(p1, p2);
    }
    internal override void ExecuteNotify(string message, object args = null)
    {
        switch(message)
        {
            case "":
                {

                }
                break;
            case "2":
                {

                }
                break;
        }
    }
}
