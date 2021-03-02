/*
* Created by Pratham Goyal
* https://github.com/Pratham9
*/
using UnityEngine;

public class OutOfBoundsDestroy : MonoBehaviour
{
    #region Variables
    AudioSource sound;
    
	#endregion
	
	#region Unity Methods

    void Start ()
    {
        sound = GetComponent<AudioSource> ();
    }
    void OnTriggerEnter(Collider collider) 
    {
        Destroy(collider.gameObject);
        sound.Play();
    }
	#endregion
}
