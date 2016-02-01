using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IdManager : MonoBehaviour 
{
    [SerializeField]
    private int nextId = 0;

    private Dictionary<uint, string> usedIds;

    public int NextId { get { return nextId++; } }

    private static IdManager instance = null;
    public static IdManager Instance
    {
        get { return instance; }
    }

    void OnEnable()
    {
        if (instance != null)
            Debug.LogError("Multiple IdManager instances");
        instance = this;
    }

    public void RegisterId(string name, uint id)
    {
        if (this.usedIds == null)
            this.usedIds = new Dictionary<uint, string>();
        if (this.usedIds.ContainsKey(id) == true)
            Debug.LogError("Duplicate: " + id + " " + name + " " + this.usedIds[id]);
        else
            this.usedIds.Add(id, name);

        if (id > this.nextId)
            this.nextId = (int)id + 1;
    }
}
