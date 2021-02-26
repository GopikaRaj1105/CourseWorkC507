using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
   public void loadGame()
    {
        SceneManager.LoadScene("level01");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
