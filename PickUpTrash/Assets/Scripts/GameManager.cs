using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public Character[] characters;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public GameObject ýnfoLevelUI;
    public GameObject failedLevelUI;
    public Character currentCharacter;

   
    

    private void Start()
    {
        InfoLevel();

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        if (characters.Length > 0)
        {
            currentCharacter = characters[0];
        }
    }

    public void SetCharacter(Character character)
    {
        currentCharacter = character;
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void InfoLevel()
    {
        ýnfoLevelUI.SetActive(true);
    }
    public void EndLevel()
    {
        failedLevelUI.SetActive(true);
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
