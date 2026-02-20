using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            GameObject.Find("GameManager").GetComponent<gameManager>().gameOver();
        }
        Debug.Log(CollisionInfo.collider.tag);
    }
    // Start is called before the first frame update
}
