using UnityEngine.SceneManagement;
using UnityEngine;

public class SahneDegis : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Restart();
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
