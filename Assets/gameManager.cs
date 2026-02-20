using UnityEngine;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void gameOver(){
        if(gameHasEnded == false)
        {
            Debug.Log("Game Over");
        }
        gameHasEnded = true;
    }
}
