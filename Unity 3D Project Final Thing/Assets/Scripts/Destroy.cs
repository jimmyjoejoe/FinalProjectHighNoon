using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public GameObject leg;

	void OnTriggerEnter (Collider Other){

		if (gameObject.tag == "boss") {
			Destroy (leg);
		}
	}
}
