using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 35f;
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

        rigid.AddForce(movement * speed);
    }
}
