using UnityEngine;
using System.Collections;

public class WeaponHandler : MonoBehaviour {
	
	public GameObject rocketLauncher;

	public GameObject railGun;


	public GameObject weaponLocation;

	public bool playerHasWeapon;

	private GameObject playerWeaponHeld; 

	void Start(){
		playerHasWeapon = false;
		playerWeaponHeld = GetComponent<GameObject>();
	}

	void Update(){
//************* trying to drop the weapon Held *****************//

		//Debug.Log(playerWeaponHeld.name);
	if(Input.GetKeyDown("q") && playerHasWeapon){
//
			Destroy(playerWeaponHeld.gameObject);
//			playerHasWeapon = false;
//			Instantiate(rocketLauncher_Pickup, new Vector3(transform.position.x,transform.position.y , (transform.position.z +5)), Quaternion.identity);
		}

		if(Input.GetMouseButtonDown(0) && playerHasWeapon){
			try{GameObject.Find("WeaponLocation").GetComponentInChildren<FireMec>().fire();}
			catch{Debug.Log("No fire script");}
		}
	}

	public void weaponGet(GameObject weaponName){
		if(playerHasWeapon){
			Debug.Log("Player got another weapon");
			//Switch weapon to picked up weapon... want to be toggle-able in the future
		}
		playerHasWeapon = true;
		playerWeaponHeld = weaponName;
//		Debug.Log(weaponName);
//		Debug.Log(playerWeaponHeld);

		if(weaponName.name == "Rocket Launcher_Pickup" || weaponName.name == "Rocket Launcher_Pickup (Clone)"){
			GameObject i = Instantiate (rocketLauncher, weaponLocation.transform.position, Quaternion.identity) as GameObject;
			i.transform.parent = GameObject.Find("WeaponLocation").transform;
			
		}else if(weaponName.name == "RailGun_Pickup"){
			try{
				GameObject b = Instantiate(railGun, weaponLocation.transform.position, Quaternion.identity) as GameObject;
				b.transform.parent = GameObject.Find("WeaponLocation").transform;
			}

			catch{
				Debug.Log ("No prefab");
			}
		}else{Debug.Log (weaponName);}

	}
}
