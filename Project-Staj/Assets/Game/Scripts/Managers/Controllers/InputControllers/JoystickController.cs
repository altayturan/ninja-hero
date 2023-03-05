using UnityEngine.EventSystems;

public class JoystickController : DynamicJoystick
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        OnMoveEvent.Invoke();
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        OnStopEvent.Invoke();
    }
    
    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        OnDragEvent.Invoke();
    }
}
