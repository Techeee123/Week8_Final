using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStartScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
