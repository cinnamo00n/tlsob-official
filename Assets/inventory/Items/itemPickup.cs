using Unity.VisualScripting;
using UnityEngine;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemPickup : MonoBehaviour
{
    public ItemData item;
    public int amount = 1;

    private void Start()
    {
        if (item != null && TryGetComponent(out SpriteRenderer sr))             //Überprüft, ob das Item nicht null ist und ob das GameObject einen SpriteRenderer hat
        {                                                                       //Wenn ja, wird das Icon des Items dem SpriteRenderer zugewiesen
            sr.sprite = item.itemIcon;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))                                //Überprüft, ob der Spieler das Item aufnimmt
        {
            Debug.Log("Aufgesammelt: " + item.itemName);              //Gibt eine Debug-Nachricht aus, dass das Item aufgesammelt wurde
            Destroy(gameObject);                                      //Zerstört das GameObject, das das Item repräsentiert
        }
    }
}

