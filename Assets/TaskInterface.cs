using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInterface : MonoBehaviour
{
    public string taskName;

    private TimeTableManager timeTableManager;

    void Start()
    {
        timeTableManager = FindObjectOfType<TimeTableManager>();
    }

    public void AddTask() {
        TaskInfo taskInfo = new TaskInfo(taskName);
        timeTableManager.AddTask(taskInfo);
    }
}
