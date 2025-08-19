using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item")]
public class Items : ScriptableObject
{
   [Header("Property")] public float cooldown;
   public itemType itemType;
   public Sprite item_sprite;
}

public enum itemType
{
   spatula, 
   meat,
   box,
};
