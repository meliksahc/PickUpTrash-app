
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("GreenSquare"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.EndLevel();
            
            
        }

    }



}
