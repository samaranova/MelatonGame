using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public void BoyEasyGame()
    {
        SceneManager.LoadScene("BoyGameSceneEasy");
    }
    public void BoyChooseDifficulty()
    {
        SceneManager.LoadScene("BoyDifficultyScene");
    }

    public void BoyMediumGame()
    {
        SceneManager.LoadScene("BoyGameSceneMed");
    }

    public void BoyHardGame()
    {
        SceneManager.LoadScene("BoyGameSceneHard");
    }

    public void GirlEasyGame()
    {
        SceneManager.LoadScene("GirlGameSceneEasy");
    }
    public void GirlChooseDifficulty()
    {
        SceneManager.LoadScene("GirlDifficultyScene");
    }

    public void GirlMediumGame()
    {
        SceneManager.LoadScene("GirlGameSceneMed");
    }

    public void GirlHardGame()
    {
        SceneManager.LoadScene("GirlGameSceneHard");
    }

    public void QuitGame()
    {
        Debug.Log("Game exited");
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void ChooseCharacter()
    {
        SceneManager.LoadScene("ChooseCharacter");
    }

}
