using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
        Debug.Log(CollisionInfo.collider.tag);
    }
    // Start is called before the first frame update
}
