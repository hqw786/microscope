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
    AimModel am;
    public AimView()
    {
        am = new AimModel();
        am.focus = 20;
        am.travel_Vertical = 25;//mm
    }
    public void Init()
    {
        zaiBoPian = GameObject.Find("/Cube/Canvas/Image");
        image = zaiBoPian.GetComponent<Image>();
        GameObject g = GameObject.Find("/Cylinder/Main Camera");
        camera = g.GetComponent<CameraFilterPack_Blur_Movie>();
    }
    public void Run()
    {
        float height = Input.GetAxis("Mouse ScrollWheel");
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (height != 0)
        {
            zaiBoPian.transform.parent.parent.position += Vector3.up * height / 1000;
        }
        if(x != 0)
        {
            zaiBoPian.transform.parent.parent.position += Vector3.right * x / 10000;
        }
        if(z != 0)
        {
            zaiBoPian.transform.parent.parent.position += Vector3.forward * z / 10000;
        }
        SettingCameraAimRadius();
    }

    public void SettingCameraAimRadius()
    {
        if (camera != null && image != null)
        {
            am.GetCurDis(camera.transform.position, image.transform.position);
            float temp = am.GetAimRadius();
            //Manager.Instance.print(temp.ToString());
            if (temp < 0)
            {
                Manager.Instance.print("模糊类返回数据出错，请检查（垂直行程为0）");
            }
            //TODO:这边先简单写一下，可能有个联动。（摄像头模糊脚本的三个联动参数调整）
            CameraFilterPack_Blur_Movie.ChangeRadius = temp;
            CameraFilterPack_Blur_Movie.ChangeFastFilter = (int)(temp / 100) + 1;
        }
    }
    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}
