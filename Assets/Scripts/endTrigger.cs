using UnityEngine;

public class endTrigger : MonoBehaviour
{
   
   void OnTriggerEnter(Collider other)
    {
        //Debug.Log("end checkpoint has touched = " + other.tag);
        if (other.CompareTag("player"))
        {
            GameObject.Find("GameManager").GetComponent<gameManager>().completeLevel();
        }
            
        
    }
}
