using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("General")] 
    public List<itemType> inventoryList;
    public int selectItem;

    [Space(20)] 
    [Header("Keys")] 
    [SerializeField] KeyCode throwItemKey;
    [SerializeField] KeyCode pickItemKey;
    
    [Space(20)]
    [Header("Item GameObject")]
    [SerializeField] GameObject spatula_item;
    [SerializeField] GameObject meat_item;
    [SerializeField] GameObject box_item;
    
    private Dictionary<itemType, GameObject> itemSetActive = new Dictionary<itemType, GameObject>();

    void Start()
    {
        itemSetActive.Add(itemType.spatula, spatula_item);
        itemSetActive.Add(itemType.meat, meat_item);
        itemSetActive.Add(itemType.box, box_item);
        
        NewItemSelected();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && inventoryList.Count > 0)
        {
            selectItem = 0;
            NewItemSelected();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && inventoryList.Count > 1)
        {
            selectItem = 1;
            NewItemSelected();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && inventoryList.Count > 2)
        {
            selectItem = 2;
            NewItemSelected();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && inventoryList.Count > 3)
        {
            selectItem = 3;
            NewItemSelected();
        }
        
    }

    private void NewItemSelected()
    {
        spatula_item.SetActive(false);
        meat_item.SetActive(false);
        box_item.SetActive(false);

        GameObject selectedItemGameobject = itemSetActive[inventoryList[selectItem]];
        selectedItemGameobject.SetActive(true);
    }
}
