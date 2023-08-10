using UnityEngine.SceneManagement;
using UnityEngine;

public class TheEndScene : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
