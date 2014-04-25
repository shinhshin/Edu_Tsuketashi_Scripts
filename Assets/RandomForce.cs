using UnityEngine;
using System.Collections;

public class RandomForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Random.Rangeは、 左の数字からから右の数字までの範囲で、ランダムな数値になる。
        // 1f の f は、「小数を含む数字」という意味。これを付けないと、「整数だけの数字」になる。
        // 上方向にランダムな力を受け続ける
        rigidbody.AddForce(new Vector3(0, Random.Range(-20, 40f), 0));
	}
}
