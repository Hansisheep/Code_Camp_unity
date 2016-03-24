using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
// --- Import des fichers --- //
using playerdeplacement;

public class MenuEchap : MonoBehaviour {

	// ------------------ Var ------------------ //
		private bool AcDs = false;
		private Canvas Menu;

	// ------------------ Base Unity ------------------ //

	// Use this for initialization
	void Start () {
		Menu = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Menu.enabled = !Menu.enabled;
			if (AcDs == false) {
				playerdeplacement.playerdeplacement.Instance.DesactiveTPS ();
				AcDs = true;
			} else if (AcDs == true) {
				playerdeplacement.playerdeplacement.Instance.ActiveTPS ();
				AcDs = false;
			}
		}
	}

	// ------------------ Mes Fonctions ------------------ //

	public void MenuMouse (){
		AcDs = false;
	}

	public void Reset (){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
