using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Events;


public class RoamManager
{
    public DOTweenPath dtPath;
    public Tweener tweener;
    
    public RoamManager()
    {
        Button button = GameObject.Find("/ACC/Canvas/Button").GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }
    
    public void StartRoam(string path)
    {
        List<Vector3> temp = new List<Vector3> ();
        foreach(Transform t in RoamPathManager.paths[path])
        {
            temp.Add(t.position);
        }

        //foreach(Vector3 v in dtPath.wps)
        //{
        //    Manager.Instance.print("wps" + v.ToString());
        //}
        //foreach (Vector3 v in dtPath.fullWps)
        //{
        //    Manager.Instance.print("fullwps" + v.ToString());
        //}
        //Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null

        
        tweener = Camera.main.transform.DOPath(temp.ToArray(), 10, PathType.CatmullRom);
        tweener.SetLoops(-1, LoopType.Yoyo);
        //tweener.SetTarget(RoamPathManager.centers[path]);
        tweener.SetEase(Ease.Linear);
        //

        //加个完成事件
        //tweener.OnComplete(DoComplete);
    }
    public void OnButtonClick()
    {
        StartRoam(Define.RoamPathName_1);
    }
    public void DoComplete()
    {
        OnButtonClick();
    }
}