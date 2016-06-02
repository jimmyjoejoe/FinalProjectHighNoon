using UnityEngine;
using System.Collections;

public class LevelChange2 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		Application.LoadLevel(3);
	}
}

