using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public string TagToNotHit = "Nothing";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != TagToNotHit)
        {
            if(other.GetComponent<StatusScript>()){
                Debug.Log("Take damage...");
                other.GetComponent<StatusScript>().TakeDmg(1);
            }
            Destroy(gameObject);
        }
    }
}
