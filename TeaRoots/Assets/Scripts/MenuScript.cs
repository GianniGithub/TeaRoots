using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

	public void ChangeScene(string Name)
	{
		SceneManager.LoadScene(Name);
	}

	public void ExitGame()
	{
		Application.Quit();

	}
}