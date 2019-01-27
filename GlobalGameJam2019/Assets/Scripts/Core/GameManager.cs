using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance = null;

    public Player player;
    public ObjectivesManager objectivesManager;
    public UIMaster uiMaster;

    private IEnumerator coroutine;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        InitScene();
    }

    void InitScene()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }
        if(objectivesManager == null)
        {
            objectivesManager = GetComponent<ObjectivesManager>();
            objectivesManager.OnAllObjectivesComplete.AddListener(NotifyLevelComplete);
            objectivesManager.OnAllObjectivesFailed.AddListener(GameOver);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NotifyLevelComplete()
    {
        Debug.Log("All objectives are complete!");
    }



    public void GameOver()
    {
        Debug.Log("Game Over!");
        player.enabled = false;
        uiMaster.restartButton.gameObject.SetActive(true);
        GetComponent<AudioSource>().pitch = -1;
    }

   

    public void RestartScene()
    {
        Debug.Log("Loading Scene: " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static GameManager Get()
    {
        return instance;
    }

}
