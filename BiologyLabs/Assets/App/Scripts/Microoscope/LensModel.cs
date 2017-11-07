using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensModel : Model
{
    public Vector3 positon;
    public float FOV;
    public float factor;//倍数
    public float focus;//焦距

    internal override void ExecuteNotify(string message, object args = null)
    {
        throw new System.NotImplementedException();
    }
}
