using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSetting : MonoBehaviour
{
    [SerializeField] Sprite sprInven;

    public void GetItem()
    {
        if (InventoryManager.Instance.GetItem(sprInven))//������ ������ ����
        {
            Destroy(gameObject);
        }
       else
        {
            Debug.LogError("������ â�� ����á��");
        }
    }



}
