using UnityEngine;

public class ItemMoneda : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.3f);
        }
    }
}
