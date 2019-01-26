using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectiveEventBase : UnityEvent<ObjectiveComponent> { }




public class ObjectiveComponent : MonoBehaviour
{

    /*Objective Events*/
    public ObjectiveEventBase OnObjectiveComplete = new ObjectiveEventBase();
    public ObjectiveEventBase OnObjectiveFailed = new ObjectiveEventBase();

    private bool bIsComplete;
    private bool bIsFailed;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void MarkCompleted()
    {
        bIsComplete = true;
        OnObjectiveComplete.Invoke(this);
    }

    public void MarkFailed()
    {
        bIsFailed = true;
        OnObjectiveFailed.Invoke(this);
    }

    public bool IsFailed()
    {
        return bIsFailed;
    }

    public bool IsComplete()
    {
        return bIsComplete;
    }
}
