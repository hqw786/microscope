using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamPathManager
{
    public static Dictionary<string, List<Transform>> paths = new Dictionary<string, List<Transform>>();
    public static Dictionary<string, Transform> centers = new Dictionary<string, Transform>();
    private Transform totalParent;
    public RoamPathManager()
    {
        totalParent = GameObject.Find("/ACC/TotalRoamPath").transform;
        Init();
    }
    /// <summary>
    /// 初始化，取得分路径下的路径点集合
    /// </summary>
    private void Init()
    {
        foreach(Transform t in totalParent)
        {
            List<Transform> temp = new List<Transform>();
            Transform center = null;
            foreach(Transform tt in t)
            {
                if (tt.name.Contains("Center"))
                {
                    center = tt;
                }
                else
                {
                    temp.Add(tt);
                }
            }
            paths.Add(t.name, temp);
            centers.Add(t.name, center);
        }
    }

}
