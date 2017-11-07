using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class AimView : View
{
    GameObject zaiBoPian;
    Image image;
    public AimView()
    {
        zaiBoPian = GameObject.Find("/Cube/Canvas/Image");
        image = zaiBoPian.GetComponent<Image>();
    }
    public void SettingAimOfPosition(Vector3 position)
    {
        float dis = GetDistance(position);

        AimModel am = GetModel<AimModel>();
        
    }
    private float GetDistance(Vector3 p)
    {
        return Vector3.Distance(p, image.transform.position);
    }

    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}
