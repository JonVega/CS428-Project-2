using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonAction : MonoBehaviour
{
	public GameObject vbBtnObj;
	public AudioSource voiceObject;
	public Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
		//anim = GetComponent<Animator>();
		vbBtnObj = GameObject.Find("button");
		voiceObject = GetComponent<AudioSource>(); vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Debug.Log("start");
    }
	
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
	         Debug.Log("Button pressed");
			 //anim.SetBool("isYelling", true);
			 anim.SetTrigger("isPushed");
			 
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
	         Debug.Log("Button released");
			 voiceObject.Play();
			 //anim.SetBool("isMad", false);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
