using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
