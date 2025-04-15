using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private KeyCode dodgeKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(dodgeKey))
        {
            Vector3 inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            if (inputDirection == Vector3.zero)
                inputDirection = transform.forward;

            this.GetComponent<DodgeController>().TryDodge(inputDirection);
        }
    }
}

