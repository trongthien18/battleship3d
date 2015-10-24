using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {
	
    public void Play()
    {
        Application.LoadLevel("Main");
    }

    public void Rate()
    {
        Application.OpenURL("google.com");
    }

	public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
