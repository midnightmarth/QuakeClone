using UnityEngine;
using System.Collections;

public class ExplosionDamage : MonoBehaviour {


	void OnTriggerEnter(Collider col){

		if(col.tag == "Player")
			col.GetComponent<HealthHandler>().healthDec(10);
		Destroy(this.gameObject);


	}
}
