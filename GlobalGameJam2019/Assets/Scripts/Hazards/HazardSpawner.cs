using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    public GameObject[] hazardPrefabs;
    public float spawnInterval = 2;
    public int maxHazards = 20;

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
        spawnedHazards.Add(Instantiate(hazardPrefabs[id]));
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
