using Unity.VisualScripting;
using UnityEngine;

public class ShieldBuff : PowerupBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffecActive)
        {
            Debug.Log("Shield");
            player.SetInvulinerability(true);
            Destroy(gameObject);
        }
    }
}
