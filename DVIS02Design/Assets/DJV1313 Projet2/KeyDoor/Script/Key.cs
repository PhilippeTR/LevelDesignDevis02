using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Key : MonoBehaviour {

	public GameObject door;

	public Color color = Color.yellow;

	// Use this for initialization
	void FixedUpdate () {
		if(door)
		{
			door.GetComponent<Renderer>().material.color = color;
		}

		Renderer[] childs = GetComponentsInChildren<Renderer>() as Renderer[];
		foreach(Renderer child in childs)
		{
			child.material.color = color;
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if(Application.isPlaying)
		{
			if(other.tag == "Player")
			{
				Destroy(this.gameObject);
				Destroy(door.gameObject);
			}
		}
	}
}
