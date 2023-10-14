using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public EventLogic eventLogic;
    public static EventManager instance;
    public void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        Destroy(this);
    }
    public void Event(string a, int b = -1)
    {
        eventLogic.Event(a, b);
    }
}
