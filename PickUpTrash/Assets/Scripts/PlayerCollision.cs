
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.name == "Enemy")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
