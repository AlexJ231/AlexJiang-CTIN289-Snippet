using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public bool haveGameEnded;
    public GameObject LevelComplete;

    private void Start()
    {
        LevelComplete.SetActive(false);
    }


    public void EndGame()
    {
        if (!haveGameEnded)
        {
            haveGameEnded = true;
            Invoke("Restart", 2f);
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void Victory()
    {
        LevelComplete.SetActive(true);
    }

    public void NextLevel()
    {

    }


}
