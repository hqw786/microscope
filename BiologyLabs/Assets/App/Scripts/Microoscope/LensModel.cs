using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensModel : Model
{
    public Vector3 positon;
    public float FOV;
    public float factor;//倍数
    public float focus;//焦距
    public Vector3 lowestPosition;  //最低位置判断是否与玻片碰撞（可以用触发器代替）

    internal override void ExecuteNotify(string message, object args = null)
    {
        throw new System.NotImplementedException();
    }
}
