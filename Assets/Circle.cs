using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Cos や Sin は、三角関数。
        // Time.time は、ゲーム再生からの時間（秒）を表す。
        rigidbody.velocity = new Vector3(Mathf.Cos(Time.time), 0, Mathf.Sin(Time.time));
	}
}
