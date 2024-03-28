using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSetting : MonoBehaviour
{
    [SerializeField] Sprite sprInven;

    public void GetItem()
    {
        if (InventoryManager.Instance.GetItem(sprInven))//아이템 넣을수 있음
        {
            Destroy(gameObject);
        }
       else
        {
            Debug.LogError("아이템 창이 가득찼음");
        }
    }



}
