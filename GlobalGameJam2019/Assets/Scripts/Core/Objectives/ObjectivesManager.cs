using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectivesManager : MonoBehaviour
{

    public UnityEvent OnAllObjectivesComplete = new UnityEvent();
    public UnityEvent OnAllObjectivesFailed = new UnityEvent();

    public ObjectiveComponent[] Objectives;

    private int NumObjectivesComplete = 0;
    private int NumObjectivesFailed = 0;

    private bool bIsListeningToObjectives = false;

    // Start is called before the first frame update
    void Start()
    {
        ResetObjectivesCount();
        ListenToObjectives();
    }

    void ResetObjectivesCount()
    {
        NumObjectivesFailed = 0;
        NumObjectivesComplete = 0;
    }

    void ListenToObjectives()
    {
        if (!bIsListeningToObjectives)
        {
            for (int i = 0; i < Objectives.Length; i++)
            {
                Objectives[i].OnObjectiveComplete.AddListener(RespondToObjectiveComplete);
                Objectives[i].OnObjectiveFailed.AddListener(RespondToObjectiveFailure);
            }

            bIsListeningToObjectives = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespondToObjectiveComplete(ObjectiveComponent completedObjective)
    {
        NumObjectivesComplete++;

        if (NumObjectivesComplete >=Objectives.Length)
        {
            OnAllObjectivesComplete.Invoke();
        }
    }

    public void RespondToObjectiveFailure(ObjectiveComponent failedObjective)
    {
        NumObjectivesFailed++;

        if(NumObjectivesFailed >= Objectives.Length)
        {
            OnAllObjectivesFailed.Invoke();
        }
    }
}
