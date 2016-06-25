// Matthew Cormack
// 24/06/16
//
// Pulsate the desired transform variables (in local space) with time
// (i.e. position/rotation/scale)

using UnityEngine;

public class PulseTransformScript : MonoBehaviour
{
	// Public inspector
	public Vector3 PulsePosition;
	public Vector3 PulseRotation;
	public Vector3 PulseScale;

	public float PulseSpeed = 1;
	public float PulseLimit = 1;
	public float PulseOffset = 0;

	// Private
	private Vector3 CurrentPosition;
	private Vector3 CurrentRotation;
	private Vector3 CurrentScale;

	void Update()
	{
		transform.localPosition -= CurrentPosition;
		transform.localEulerAngles -= CurrentRotation;
		transform.localScale -= CurrentScale;

		// Pulsate
		float change = Mathf.Sin( ( Time.time * PulseSpeed ) + PulseOffset ) * PulseLimit;
		{
			CurrentPosition = PulsePosition * change;
			CurrentRotation = PulseRotation * change;
			CurrentScale = PulseScale * change;
		}
		transform.localPosition += CurrentPosition;
		transform.localEulerAngles += CurrentRotation;
		transform.localScale += CurrentScale;
	}
}
