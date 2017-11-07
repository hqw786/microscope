using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Model
{
    //存储
    protected Dictionary<string, System.Action> NotifyEvent = new Dictionary<string, System.Action>();

    protected void RegisterModel(Model m)
    {
        MVC.RegisterModel(m);
    }

    /// <summary>
    /// 注册通知事件
    /// </summary>
    /// <param name="message"></param>
    /// <param name="func"></param>
    protected void RegisterNotifyEvent(string message, System.Action func)
    {
        NotifyEvent.Add(message, func);
    }

    /// <summary>
    /// 执行通知事件，视图那边做修改
    /// </summary>
    /// <param name="message"></param>
    /// <param name="args"></param>
    internal abstract void ExecuteNotify(string message, object args = null);
}
