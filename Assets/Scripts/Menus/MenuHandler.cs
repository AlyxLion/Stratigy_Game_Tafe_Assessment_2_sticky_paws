using System.Collections;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuHandler : MonoBehaviour
{
	public void ToGame()
	{
		SceneManager.LoadScene(1);
	}

	public void ToMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void Exit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
		Application.Quit();
	}
}
