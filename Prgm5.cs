using UnityEngine;


public class Prog5 : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float distance = 10f;

    RaycastHit2D hit;


    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        hit = Physics2D.Raycast(transform.position, transform.right, distance);

        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, hit.point, Color.red);
            Debug.Log("Hit: " + hit.collider.name + " | Distance: " + hit.distance);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.right * distance, Color.green);
            Debug.Log("No hit");
        }
    }
}