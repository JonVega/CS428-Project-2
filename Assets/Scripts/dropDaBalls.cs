using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropDaBalls : MonoBehaviour
{
	
	public GameObject table;
	public GameObject redBall;
	
    // Start is called before the first frame update
    void Start()
    {
		table = GameObject.Find("tabletop");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Pressed primary button.");
			
			//gets the local scale of an object
			Vector3 local = transform.localScale;
			Debug.Log(local);
			
			
			for(int i = 0; i < 15; i++) {
				//var clone = Instantiate(redBall, new Vector3(-0.05f,0.08f, 0.24f), Quaternion.identity);
				var clone = Instantiate(redBall, new Vector3(0.0f,0.15f, 0.05f), Quaternion.identity);
				Destroy (clone, 4.0f);
			}
			
		}
		
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("Pressed secondary button.");
		}
		
        if (Input.GetMouseButtonDown(2)) {
            Debug.Log("Pressed middle click.");
        }
    }
}
