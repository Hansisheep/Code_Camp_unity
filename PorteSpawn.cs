using UnityEngine;
using System.Collections;

namespace TriggerPorte
{

	public class PorteSpawn : MonoBehaviour 
	{

		// ------------------ Var ------------------ //

		public static PorteSpawn Instance;
		public float moveSpeed = 2f;
		private float y;
		private float newPositionY;
		public float ouverture = -3.98f;
		public float fermeture = 0f;

		// ------------------ Instance ------------------ //

		void Awake()
		{
			Instance = this;
		}

		// ------------------ Mes Fonctions ------------------ //

		public bool Descend ()
		{
			y = transform.position.y;

			if (y >= ouverture) {
				this.transform.Translate (-Vector3.up * moveSpeed * Time.deltaTime);
				TriggerSon.son.Instance.playSound ();
				return true;
			} else {
				return false;
			}
		}

		public void Monter ()
		{
			y = transform.position.y;

			if (y <= fermeture) {
				this.transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
				TriggerSon.son.Instance.playSoundF ();
			}
		}
	}

}