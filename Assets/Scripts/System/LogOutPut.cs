using UnityEngine;
using System;
using System.IO;
using System.Collections;

public class LogOutPut : MonoBehaviour 
{
	public string Condition;
    public string StackTrace;
    public LogType Type;
    
    private void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    private void HandleLog(string condition, string stackTrace, LogType type)
    {
        Condition   = condition;
        StackTrace  = stackTrace;
        Type        = type;
    }

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 150, 100), Condition);
	}
}
