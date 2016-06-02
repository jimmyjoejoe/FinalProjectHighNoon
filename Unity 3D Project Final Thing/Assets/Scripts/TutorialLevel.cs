using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialLevel : MonoBehaviour {

	public Text Tutoriallevel;
	
	IEnumerator OnTriggerEnter (Collider other){

		if (other.tag == "TutorialText") {

			Tutoriallevel.text = ("The Objective of the Game is to escape the Complex"); 
			yield return new WaitForSeconds (3);
			Tutoriallevel.text = ("Avoid enemies and collect the Keys to Escape");
			yield return new WaitForSeconds (3);
			Tutoriallevel.text = ("Good Luck.");
			yield return new WaitForSeconds (3);
			Tutoriallevel.text = ("");
		}
	}
	
	
} 
