using UnityEngine;
using System.Collections;
// --- Import des fichers --- //
using TriggerPorte;

public class TriggerOuverturePorte : MonoBehaviour {

	// ------------------ Var ------------------ //

	public bool porte1 = false;

	// ------------------ Base Unity ------------------ //

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (porte1 == true) {
			porte1 = TriggerPorte.PorteSpawn.Instance.Descend ();
		}
	}

	// ------------------ Mes Fonctions ------------------ //

	void OnTriggerEnter (Collider target)
	{
		if (target.tag == "Player") {
			porte1 = true;
		}
	}
}
