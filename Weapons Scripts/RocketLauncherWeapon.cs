using UnityEngine;
using System.Collections;

public class RocketLauncherWeapon : MonoBehaviour {

	public int fireSpeed = 5;
	
	public Rigidbody rocket;
	public Transform firePos;
	private Vector3 xyzFireLocation;


	void Start(){

		firePos = GameObject.Find("WeaponAim").transform;



	}
	public void fire(){
		xyzFireLocation = firePos.position;
		Instantiate(rocket, xyzFireLocation, transform.rotation);
		//clone.velocity = transform.TransformDirection(new Vector3(0,0,fireSpeed));
		//clone.AddForce(transform.forward);
	}
}
