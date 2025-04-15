using System;
using UnityEngine;

public class DodgeController : MonoBehaviour
{
    public static event Action OnDodge; 
    public static Func<bool> CanDodge; 

    [SerializeField] private float dodgeForce = 5f;

    public void TryDodge(Vector3 dodgeDirection)
    {
        if (CanDodge != null && CanDodge())
        {
            GetComponent<Rigidbody>().AddForce(dodgeDirection.normalized * dodgeForce, ForceMode.VelocityChange);

            Debug.Log("Esquive ejecutado.");
            OnDodge?.Invoke();
        }
        else
        {
            Debug.Log("No puedes esquivar ahora.");
        }
    }
}
