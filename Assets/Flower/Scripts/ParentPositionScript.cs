// Matthew Cormack
// 24/06/16
//
// Parent the position of this gameobject to another's position
// (i.e. without scaling, rotating)

using UnityEngine;

public class ParentPositionScript : MonoBehaviour
{
	public GameObject AttachObject = null;

	void Update()
	{
		if ( AttachObject != null )
		{
			transform.position = AttachObject.transform.position;
        }
	}
}
