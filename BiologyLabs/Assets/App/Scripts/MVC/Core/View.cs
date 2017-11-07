using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;


public abstract class View //: MonoBehaviour
{
    //存储请求事件
    protected Dictionary<string, System.Action<object>> RequestEvent = new Dictionary<string, System.Action<object>>();

    //视图名称
    //protected virtual string Name { get; }

    /// <summary>
    /// 注册请求事件
    /// </summary>
    /// <param name="message"></param>
    /// <param name="func"></param>
    protected void RegisterRequestEvent(string message, System.Action<object> func)
    {
        RequestEvent.Add(message, func);
    }

    /// <summary>
    /// 模型状态查询
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    protected T GetModel<T>() where T : Model
    {
        return MVC.GetModel<T>();
    }

    /// <summary>
    /// 执行请求事件，控制器作出反应
    /// </summary>
    /// <param name="message"></param>
    /// <param name="args"></param>
    internal abstract void ExecuteRequest(string message, object args = null);
}
