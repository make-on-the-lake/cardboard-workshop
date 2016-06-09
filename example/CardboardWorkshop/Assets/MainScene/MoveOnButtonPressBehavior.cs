using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class MoveOnButtonPressBehavior : MonoBehaviour {

	void Start () {
		GvrViewer.Instance.OnTrigger += this.onTrigger;
	}

	void Update () {
	}

	void onTrigger() {
		var fpController = this.gameObject.GetComponent<RigidbodyFirstPersonController> ();
		fpController.IsMovingForward = !fpController.IsMovingForward;
	}
}
