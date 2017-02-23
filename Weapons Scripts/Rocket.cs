using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
	public int fireSpeed = 20;
	public ParticleSystem explosion;

	// Update is called once per frame
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(transform.forward * fireSpeed);
	}
	void OnCollisionEnter(Collision col){
		Destroy(this.gameObject);
		Instantiate (explosion, this.transform.position, Quaternion.identity);
	}
}
