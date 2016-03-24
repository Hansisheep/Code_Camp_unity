using UnityEngine;
using System.Collections;

namespace TriggerSon
{
	[RequireComponent(typeof(AudioSource))]
	public class son : MonoBehaviour {

		// ------------------ Var ------------------ //

		public AudioClip openPorte;
		AudioSource audio;
		private bool Oneplay = false;
		private bool Twoplay = false;
		public static son Instance;

		// ------------------ Instance ------------------ //

		void Awake(){
			Instance = this;
		}

		// ------------------ Mes Fonctions ------------------ //

		public void playSound ()
		{
			if (Oneplay == false) {
			audio = GetComponent<AudioSource>();
				Oneplay = true;
				audio.PlayOneShot (openPorte, 0.7F);
			}
		}

		public void playSoundF ()
		{
			if (Twoplay == false) {
				audio = GetComponent<AudioSource>();
				Twoplay = true;
				audio.PlayOneShot (openPorte, 0.7F);
			}
		}

	}
}