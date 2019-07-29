using UnityEngine;

public class BoundsTool
{
    #region Singletone

    private static BoundsTool _instance;

    public static BoundsTool instance
    {
        get { return _instance ?? (_instance = new BoundsTool()); }
    }

    #endregion

    public Bounds GetBounds(Transform t)
    {
        var renderer = t.GetComponentsInChildren<Renderer>();
        var bounds = new Bounds(t.position, Vector3.zero);

        if (renderer.Length < 1)
        {
            return bounds;
        }

        foreach (var item in renderer)
        {
            if (item.gameObject.activeInHierarchy && item.bounds.size != Vector3.zero)
                bounds = Add(bounds, item.bounds);
        }

        return bounds;
    }

    public Bounds GetBounds(Transform t, string nameForSearch)
    {
        var rend = t.GetComponentsInChildren<Renderer>();
        var bounds = new Bounds(t.position, Vector3.zero);

        if (rend.Length < 1)
            return bounds;

        foreach (var renderer in rend)
        {
            if (renderer.gameObject.activeInHierarchy && renderer.bounds.size != Vector3.zero && renderer.gameObject.name.Contains(nameForSearch))
                bounds = Add(bounds, renderer.bounds);
        }

        return bounds;
    }

    public Bounds GetBoundsAll(Transform t)
    {
        var rend = t.GetComponentsInChildren<Renderer>(true);
        var bounds = new Bounds(t.position, Vector3.zero);

        if (rend.Length < 1)
            return bounds;

        foreach (var renderer in rend)
        {
            if (renderer.bounds.size.x * renderer.bounds.size.y > 1f)
                bounds = Add(bounds, renderer.bounds);
        }

        return bounds;
    }

    public Bounds Add(Bounds b1, Bounds b2)
    {
        Vector3 min = new Vector3(Mathf.Min(b1.min.x, b2.min.x), Mathf.Min(b1.min.y, b2.min.y), Mathf.Min(b1.min.z, b2.min.z)),
        max = new Vector3(Mathf.Max(b1.max.x, b2.max.x), Mathf.Max(b1.max.y, b2.max.y), Mathf.Max(b1.max.z, b2.max.z));

        return new Bounds((max + min) / 2f, max - min);
    }
}
