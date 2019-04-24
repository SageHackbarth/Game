using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public void BackToStart()
    {
        SceneManager.LoadScene("Menu");
    }
}
