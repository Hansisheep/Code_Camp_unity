using UnityEngine;
using System.Collections;

namespace playerdeplacement
{

	public class playerdeplacement : MonoBehaviour {

		// ------------------ Var ------------------ //

			public float turnSpeed = 100f;

			public static playerdeplacement Instance;
			private static GameObject Cam;
			int floorMask;
			public bool Test1 = false;
			public Rigidbody rb;
			private float mouseX;
			private float mouseY;

		// ------------------ Instance ------------------ //

			void Awake(){
				Instance = this;
			}

		// ------------------ Base Unity ------------------ //

		// Use this for initialization
		void Start () {
				rb = GetComponent<Rigidbody>();
				Cam = GameObject.FindWithTag("MainCamera");
		}


		// Update is called once per frame
		void Update () {

			if (Test1 == true) {
				HandleMouseRotation ();
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}



			if(Input.GetKey(KeyCode.Q))
				                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
				            if(Input.GetKey(KeyCode.Q))
				                rb.velocity = new Vector3(0, 0, 0);
				
				            if(Input.GetKey(KeyCode.E))
				                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
				            if(Input.GetKey(KeyCode.E))
				                rb.velocity = new Vector3(0, 0, 0);





	 		mouseX = Input.GetAxis("Mouse X");
			mouseY = Input.GetAxis("Mouse Y");
		}

			// ------------------ Mes Fonctions ------------------ //

			public void HandleMouseRotation()
			{
				var easeFactor = 500f;
				if (Input.GetAxis("Mouse X") != mouseX) {
					var cameraRotationY = Input.GetAxis("Mouse X") * easeFactor;
					this.transform.Rotate(Vector3.up, cameraRotationY * Time.deltaTime);
				}
				if (Input.GetAxis("Mouse Y") != mouseY) {
					var cameraRotationY = Input.GetAxis("Mouse Y") * easeFactor;
				Cam.transform.Rotate(Vector3.left, cameraRotationY * Time.deltaTime);
					Debug.Log ("Test souri");
					Debug.Log (mouseY);
				}

			}

			public void ActiveTPS()
			{
				Test1 = true;
			}

			public void DesactiveTPS()
			{
				Test1 = false;
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = true;
			}
	}
}