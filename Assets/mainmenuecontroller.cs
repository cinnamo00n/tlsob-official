using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuecontroller : MonoBehaviour
{
    public void StartGame()
    {
       SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
