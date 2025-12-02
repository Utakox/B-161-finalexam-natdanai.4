using Unity.VisualScripting;
using UnityEngine;

public class SpeedBoost : PowerupBase

{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffecActive)
        {
            player.SetMoveSpeed(5f);
            Destroy(gameObject);
        }
    }
}


