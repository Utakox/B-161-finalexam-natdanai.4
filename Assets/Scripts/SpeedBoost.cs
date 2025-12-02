using Unity.VisualScripting;
using UnityEngine;

public class SpeedBoost : PowerupBase

{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffecActive)
        {
            Debug.Log("Speed");
            player.SetMoveSpeed(10f);
            
            Destroy(gameObject);
        }
    }
}


