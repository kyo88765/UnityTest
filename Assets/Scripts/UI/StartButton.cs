using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartButton : MonoBehaviour {

	public void OnButtonClicked() {

		SceneManager.LoadScene ("main");
	}
}
