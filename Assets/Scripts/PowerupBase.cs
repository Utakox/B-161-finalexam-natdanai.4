using UnityEngine;

public abstract class PowerupBase : MonoBehaviour
{
    protected bool IsEffecActive = false;



public abstract void ApplyEffect(Player effect);

}
