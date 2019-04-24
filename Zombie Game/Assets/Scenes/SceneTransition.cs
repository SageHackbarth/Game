using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
