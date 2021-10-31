using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Tank stats")]
public class TankStats : ScriptableObject
{
    [Header("Health")]
    public float m_StartingHealth = 100f;       // The amount of health the tank starts with.
    [Header("Movement")]
    public float m_Speed = 12f;                 // How fast the tank moves forward and back.
    public float m_TurnSpeed = 180f;            // How fast the tank turns in degrees per second.
    [Header("Shooting")]
    public float m_MinLaunchForce = 15f;        // The force given to the shell if the fire button is not held.
    public float m_MaxLaunchForce = 30f;        // The force given to the shell if the fire button is held for the max charge time.
    public float m_MaxChargeTime = 0.75f;       // How long the shell can charge for before it is fired at max force.
}
