using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Vector3 position = transform.position;
        DetailPosition t = new DetailPosition()
        {
            x = position.x,
            z = position.z
        };

        DetailPosition[] ts = new DetailPosition[3];
        ts[0] = t;
        ts[1] = t;
        ts[2] = t;

        DetailPositions details = new DetailPositions()
        {
            ds = ts,
        };
        string s = JsonUtility.ToJson(details);
        Debug.Log(s);
    }
}

