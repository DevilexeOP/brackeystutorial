using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartTime = 2f;
    public GameObject completeUI;

    public void CompleteLevel()
    {
        completeUI.SetActive(true);
    }

    public void GameOver() 
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game over");
            Invoke("GameRestart", restartTime);
        }
       
    }

    void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
