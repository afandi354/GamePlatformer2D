using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {
	
	public void MenuScene(){
		SceneManager.LoadScene("Menu");
	}
	
	public void LoadingScene(){
		SceneManager.LoadScene("Loading");
	}
	
	public void KeluarScene(){
		Application.Quit();
	}
}
