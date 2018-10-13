using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour {

	private InputHandler inputHandler ;
	private Command cmd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (inputHandler.HandleInput() != null)
		{
			Command cmd = inputHandler.HandleInput(); // Me devuelve que commando se va a ejecutar
			cmd.Execute(this.gameObject); //Ejecuta el comando especifico,aca podria ir cualquier cosa, siempre y cuando matchee con algun comando. 
		}		
	}
}
