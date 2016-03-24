using UnityEngine;
using System.Collections;
// --- Import des fichers --- //
using TriggerPorte;
using RecupGrav;

public class TriggerFermeturePorte : MonoBehaviour {

	// ------------------ Var ------------------ //

	public bool porteF = false;
	public bool OkTombe = true;

	// ------------------ Base Unity ------------------ //

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (porteF == true) {
			TriggerPorte.PorteSpawn.Instance.Monter ();
		}
	}

	// ------------------ Mes Fonctions ------------------ //

	void OnTriggerEnter (Collider target)
	{
		if (target.tag == "Player") {
			porteF = true;
		}

		RecupGrav.RecupGrav.Instance.RecupGravity ();
		RecupGrav1.RecupGrav1.Instance.RecupGravity ();

	}
}
