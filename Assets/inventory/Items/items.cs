using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject //ScriptableObject -> datencontainer, der es ermöglicht, Daten zu speichern und zu verwalten, ohne dass ein GameObject in der Szene vorhanden sein muss
{
    public string itemName; //Name des Items
    public Sprite itemIcon; //Icon des Items
    public int itemID;      //ID des Items
    public bool isStackable = true; //gibt an, ob das Item stapelbar ist
    public int maxStackSize = 99; //maximale Stapelgröße des Items

    public virtual void Use()
    {
        Debug.Log(itemName + " benutzt!"); //Methode, die aufgerufen wird, wenn das Item benutzt wird
    }
}
