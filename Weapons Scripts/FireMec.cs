using UnityEngine;
using System.Collections;

public class FireMec : MonoBehaviour {


	//Dropdown inspector
	//0					1
	public enum allWeapons{rocketLauncher = 0, railGun = 1};
	public allWeapons weapons;
	//


	//Rocket Launcher stuff
	[Header("Rocket Launcher stuff")]
	public int fireSpeed = 5;
	public Rigidbody rocket;
	public Transform firePos; // fire instantiation position
	private Vector3 xyzFireLocation;
	//

	//Railgun stuff
	[Header ("RailGun Stuff")]
	public float range = 1000;
	public int railDamage = 80;
	private LineRenderer line;
	//

	void Start(){
		//autosets the firePos
		firePos = GameObject.Find("WeaponAim").transform;

		try{
			line = GetComponent<LineRenderer>();
			line.SetVertexCount(2);
		}
		catch{
			Debug.Log ("Not Using Railgun");
		}
	}
	
	public void fire () {
		switch(weapons){

		case allWeapons.rocketLauncher:
			xyzFireLocation = firePos.position;
			try{Instantiate(rocket, xyzFireLocation, transform.rotation);}
			catch{Debug.Log ("Something went wrong...");}
			break;

		case allWeapons.railGun:
			Debug.Log("Fire railGun");
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			line.SetPosition(0, ray.origin);
			if(Physics.Raycast(ray, out hit , range)){
				line.SetPosition(1, hit.point);
				line.enabled = true;
				if(hit.transform.gameObject.tag == "Player"){
					hit.transform.gameObject.GetComponent<HealthHandler>().healthDec(railDamage);
				}

			}
			break;

		default:
			Debug.Log("No Weapon to fire!");
			break;
		}
	}
}
