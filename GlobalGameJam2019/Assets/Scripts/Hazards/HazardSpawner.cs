using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    public GameObject[] hazardPrefabs;
    public float spawnInterval = 2;
    public int maxHazards = 20;

    public Transform initialMovementTarget;
    public List<GameObject> spawnedHazards;
    

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = WaitAndSpawn(spawnInterval);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandomHazard()
    {
        SpawnHazard(Random.Range(0, hazardPrefabs.Length));
    }

    public void SpawnHazard(int id)
    {
       
        GameObject newObject = Instantiate(hazardPrefabs[id], transform);
        int index = FindOpenIndex();

        if(initialMovementTarget)
        {
            MoveTowardsTarget targeting = newObject.GetComponent<MoveTowardsTarget>();
            if(targeting)
            {

                targeting.SetTarget(initialMovementTarget);
            }
        }

      
        if (index >= 0)
        {
            spawnedHazards[index] = newObject;
        }
        else
        {
            spawnedHazards.Add(newObject);
        }
    }

    private int FindOpenIndex()
    {
        for (int i = 0; i < spawnedHazards.Count; i++)
        {
            if (spawnedHazards[i] == null)
                return i;
        }
        return -1;
    }

    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while(spawnedHazards.Count < maxHazards)
        {
            SpawnRandomHazard();
            yield return new WaitForSeconds(waitTime);
        }
    }
}
