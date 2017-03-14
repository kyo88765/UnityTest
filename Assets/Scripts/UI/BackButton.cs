using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void OnButtonClicked()
    {

        SceneManager.LoadScene("setup");
    }
}
