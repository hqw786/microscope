using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    public void OnLevelWasLoaded(int level)
    {
        if (level == 3)
        {
            Manager.Instance.stateMachine.menuView.Init();
        }
        if(level == 4)
        {
            Manager.Instance.stateMachine.runView.Init();
        }
    }

    //Manager manager = Manager.GetInstance();
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        Manager.Instance.SetStateMachineState(State.Init);
        Manager.Instance.print("启动");
	}
	
	// Update is called once per frame
	void Update () {
        Manager.Instance.stateMachine.Run();
	}
}
