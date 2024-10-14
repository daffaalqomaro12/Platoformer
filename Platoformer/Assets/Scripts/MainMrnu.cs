using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMrnu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playGame(){
        SceneManager.LoadScene("Game");
    }

    public void quitGame(){
        Application.Quit();
        Debug.Log("QUIT!!");
    }

}
