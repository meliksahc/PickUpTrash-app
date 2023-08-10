using UnityEngine.SceneManagement;
using UnityEngine;

public class TheEnd : MonoBehaviour
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

