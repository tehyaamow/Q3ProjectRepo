using UnityEngine;

public class endTrigger : MonoBehaviour
{
   
   void OnTriggerEnter(Collider collisionInfo)
    {
        if (CollisonInfo.collider.tag == "levelEnd"){
            GameObject.Find("GameManager").GetComponent<gameManager>().completeLevel();
        }
        
    }
}
