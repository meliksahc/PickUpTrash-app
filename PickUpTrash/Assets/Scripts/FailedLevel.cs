using UnityEngine.SceneManagement;
using UnityEngine;

public class FailedLevel : MonoBehaviour
{
    public void LoadEndLevel()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
