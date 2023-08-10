
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.CompleteLevel();
        }

    }
}
