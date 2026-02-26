using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartWait = 1f;
    public GameObject completeLevelUI;
    public void completeLevel()
    {
        Debug.Log("Player has completed the level");
        
        completeLevelUI.SetActive(true);
        
    }
    public void gameOver()
    {
        //Debug.Log("GameOver method has been called");
        if (gameHasEnded == false)
        {
            //
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("Restart", restartWait);
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
