using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller
{
    /// <summary>
    /// 模型状态改变
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected T GetModel<T>() where T : Model
    {
        return MVC.GetModel<T>();
    }

    /// <summary>
    /// 视图选择
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected T GetView<T>() where T : MonoBehaviour
    {
        return MVC.GetView<T>();
    }

    /// <summary>
    /// 执行
    /// </summary>
    /// <param name="args"></param>
    public abstract void Execute(object args = null);
}
