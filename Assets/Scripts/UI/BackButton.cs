using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackButton : MonoBehaviour
{
    public void OnButtonClicked()
    {

        SceneManager.LoadScene("setup");
    }
}
