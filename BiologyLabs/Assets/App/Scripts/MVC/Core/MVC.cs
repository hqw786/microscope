using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//MVC中间类
internal static class MVC
{
    //存储
    private static List<View> views = new List<View>();
    private static List<Model> models = new List<Model>();
    private static List<Controller> controllers = new List<Controller>();
    private static Dictionary<string, Controller> dicControllers = new Dictionary<string, Controller>();

    /// <summary>
    /// 注册视图
    /// </summary>
    /// <param name="v"></param>
    public static void RegisterView(View v)
    {
        views.Add(v);
    }
    /// <summary>
    /// 获取视图
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T GetView<T>() where T : class
    {
        foreach(View v in views)
        {
            if(v is T)
            {
                return v as T;
            }
        }
        return null;
    }

    /// <summary>
    /// 注册模型
    /// </summary>
    /// <param name="m"></param>
    public static void RegisterModel(Model m)
    {
        models.Add(m);
    }
    /// <summary>
    /// 获取模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T GetModel<T>() where T : Model
    {
        foreach(Model m in models)
        {
            if(m is T)
            {
                return m as T;
            }
        }
        return null;
    }

    /// <summary>
    /// 注册控制器
    /// </summary>
    /// <param name="message"></param>
    /// <param name="c"></param>

    public static void RegisterController(string message, Controller c)
    {
        dicControllers.Add(message, c);
    }
    
    /// <summary>
    /// 按消息执行
    /// </summary>
    /// <param name="message"></param>
    /// <param name="args"></param>
    public static void Execute(string message, object args = null)
    {
        //按消息执行C
        foreach(string s in dicControllers.Keys)
        {
            if(s.Contains(message))
            {
                dicControllers[s].Execute(args);
                break;
            }
        }
        //按消息执行V
        foreach(View v in views)
        {
            v.ExecuteRequest(message, args);
        }
        //按消息执行M
        foreach(Model m in models)
        {
            m.ExecuteNotify(message, args);
        }
    }
}
