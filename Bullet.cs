using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 3;
    Vector3 direction;
    [SerializeField] float lifeTime = 5f;


void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    public void setDirection(Vector3 dir)
    {
        direction = dir;
    }

    void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
        speed += 1f;

        Collider[] targets = Physics.OverlapSphere(transform.position, 1);
        foreach (var item in targets)
        {
            Debug.Log("Detectado: " + item.gameObject.name + " | Tag: " + item.tag);

            if (item.tag == "Enemy")
            {
                Destroy(item.transform.root.gameObject);
                Destroy(gameObject);
                break;
            }
        }
    }
}
