using GameCore.Sets;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Item")]
public class SampleConsumableItem : ConsumableItem
{
    public override void ConsumeItem(GameObject consumer)
    {
        throw new System.NotImplementedException();
    }
}