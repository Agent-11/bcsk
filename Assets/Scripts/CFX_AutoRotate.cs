using UnityEngine;

public class CFX_AutoRotate : MonoBehaviour
{
	public Vector3 rotation;

	public Space space = Space.Self;

	private void Update()
	{
		transform.Rotate(rotation * Time.deltaTime, space);
	}
}
