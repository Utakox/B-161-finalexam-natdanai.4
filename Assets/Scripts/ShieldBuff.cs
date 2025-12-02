using UnityEngine;

public class ShieldBuff : PowerupBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffecActive)
        {
            player.SetInvulinerability(true);
            Destroy(gameObject );
        }
    }
}
