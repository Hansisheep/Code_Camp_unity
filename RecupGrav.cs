using UnityEngine;
using System.Collections;

namespace RecupGrav
{

	public class RecupGrav : MonoBehaviour {

			public static RecupGrav Instance;
			public bool OkTombe = false;
			static Rigidbody rb;

			void Awake()
			{
				Instance = this;
			}

		// Use this for initialization
		void Start () {
				rb = GetComponent<Rigidbody>();
		}
		
			public void RecupGravity ()
			{
				Debug.Log ("Je tombe, ahhhh !!!");
				rb.useGravity = true;
			}
	}

}