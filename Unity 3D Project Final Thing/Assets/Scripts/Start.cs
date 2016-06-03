using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {
	public void ChangeToScene(string sceneToChangeTo){
		Application.LoadLevel (sceneToChangeTo);
	}
}