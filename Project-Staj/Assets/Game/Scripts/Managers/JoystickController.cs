using ninjahero.events;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : DynamicJoystick
{
    [SerializeField] private PlayerData playerData;
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
    }
}
