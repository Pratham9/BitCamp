/*
* Created by Pratham Goyal
* https://github.com/Pratham9
*/
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Variables

    public Transform target;
    public Vector3 offset;

	#endregion
	
	#region Unity Methods
    

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
	#endregion
}
