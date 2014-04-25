using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // angularは、角度を表す
        // Y軸まわりに10の速度で回転する
        rigidbody.angularVelocity = new Vector3(0, 10, 0);
	}
}
