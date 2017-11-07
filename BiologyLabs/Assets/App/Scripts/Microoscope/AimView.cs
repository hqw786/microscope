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
    CameraFilterPack_Blur_Movie camera;
    public AimView()
    {
        zaiBoPian = GameObject.Find("/Cube/Canvas/Image");
        image = zaiBoPian.GetComponent<Image>();
        GameObject g = GameObject.Find("/Cylinder/Main Camera");
        camera = g.GetComponent<CameraFilterPack_Blur_Movie>();

        AimModel am = new AimModel();
    }
    public void SettingCameraAimRadius()
    {
        AimModel am = GetModel<AimModel>();
        am.GetCurDis(camera.transform.position, image.transform.position);
        float temp = am.GetAimRadius();
        if(temp < 0)
        {
            Manager.Instance.print("模糊类返回数据出错，请检查（垂直行程为0）");
        }
        //TODO:这边先简单写一下，可能有个联动。（摄像头模糊脚本的三个联动参数调整）
        camera.Radius = temp;
    }
    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}
