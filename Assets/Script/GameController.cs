using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	[SerializeField]
	private Toggle audioToggle;
	// public AudioSource audio;
	
	private void Awake()
	{
		if (!PlayerPrefs.HasKey("music"))
		{
			PlayerPrefs.SetInt("music", 1);
			audioToggle.isOn = true;
			PlayerPrefs.Save();
		}
		else
		{
			if (PlayerPrefs.GetInt("music") == 1)
			{
				audioToggle.isOn = true;
			}
			else
			{
				audioToggle.isOn = false;
			}
		}
	}
	
    void Start()
    {
    }

    void Update()
    {
    }
	
	public void StartGame()
	{
		//Debug.Log("Start game");
		SceneManager.LoadSceneAsync(1);
		SceneManager.LoadSceneAsync(2);
	}
	
		public void StartMeny()
	{
		//Debug.Log("Start game");
		SceneManager.LoadScene(0);
	}
	
	public void ExitGame()
	{
	#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
	#else
		Application.Quit();
	#endif
	}
	
	
	public void OnToggleChange()
	{
		if (audioToggle.isOn)
		{
			 //audio.play();
		}
		else
		{
			//audio.stop();
		}
	}
}
