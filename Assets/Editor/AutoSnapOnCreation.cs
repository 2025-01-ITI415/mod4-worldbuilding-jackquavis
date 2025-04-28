using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class AutoSnapOnCreation
{
    static AutoSnapOnCreation()
    {
        // Listen for when objects are placed in the scene
        ObjectFactory.componentWasAdded += SnapToGrid;
    }

    static void SnapToGrid(Component component)
    {
        if (component == null) return;

        Transform transform = component.transform;
        if (transform == null) return;

        // Snap position to nearest whole number
        Vector3 pos = transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        pos.z = Mathf.Round(pos.z);
        transform.position = pos;
    }
}
