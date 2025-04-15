using UnityEngine;

public class DodgeCooldown : MonoBehaviour
{
    [SerializeField] private float cooldownTime = 1f;
    private float lastDodgeTime;

    void OnEnable()
    {
        DodgeController.CanDodge += CanPerformDodge;
        DodgeController.OnDodge += RegisterDodge;
    }

    void OnDisable()
    {
        DodgeController.CanDodge -= CanPerformDodge;
        DodgeController.OnDodge -= RegisterDodge;
    }

    private bool CanPerformDodge()
    {
        return Time.time >= lastDodgeTime + cooldownTime;
    }

    private void RegisterDodge()
    {
        lastDodgeTime = Time.time;
    }
}

