using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadState ()
    {
        SceneManager.LoadScene("State");
    }
    public void LoadSingleton()
    {
        SceneManager.LoadScene("Init");
    }
}
