using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    public void OnLevelWasLoaded(int level)
    {

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
