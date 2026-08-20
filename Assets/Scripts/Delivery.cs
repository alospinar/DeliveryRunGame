using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 0.3f;

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.CompareTag("Package")&& !hasPackage)
        {
            Debug.Log("Pick up Package");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(Collision.gameObject, delay);
        }
        if (Collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered Package");
            GetComponent<ParticleSystem>().Stop();
            hasPackage = false;
            Destroy(Collision.gameObject, delay);
        }
        
    }
}
