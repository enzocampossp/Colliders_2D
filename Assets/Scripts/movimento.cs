using UnityEngine;

public class movimento : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    private float horizontal;
    [SerializeField]
    private float movimentoSpeed;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        movimentoSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

    }
    void HandMovimento(float horizontal)
    {
        myRigidbody.linearVelocity = new Vector2(horizontal * movimentoSpeed, myRigidbody.linearVelocity.y);
        Debug.Log(horizontal);
    }

}
