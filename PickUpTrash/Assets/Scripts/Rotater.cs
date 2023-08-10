using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour
{


	void Update()
	{

		transform.Rotate(new Vector3(15, 30, 0) * Time.deltaTime);
	}
}