using UnityEngine;
using System.Collections;

public class ClientObject : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		MyService service = new MyService ();
		int n = service.Add (2, 3);
		Debug.Log (n);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
