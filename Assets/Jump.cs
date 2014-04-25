using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 0.5f) // 地面からの高さが0.5（Cubeの高さは1)より小さい場合だけ、
        {
            rigidbody.velocity = new Vector3(0, 10, 0); // Y方向に10の速度で動く
        }
	}
}
