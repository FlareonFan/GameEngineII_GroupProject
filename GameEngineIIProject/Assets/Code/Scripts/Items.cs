using System.Text;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu]
public class Items : ScriptableObject
{
    [SerializeField] string id;
    public string ID { get { return id; } }
    public string ItemName;
    public Sprite Icon;
    [Range(1, 999)]
    public int MaximumStacks = 1;

    protected static readonly StringBuilder sb = new StringBuilder();

    protected virtual void OnValidate()
    {
        string path = AssetDatabase.GetAssetPath(this);
        id = AssetDatabase.AssetPathToGUID(path);
    }

    public virtual Items GetCopy()
    {
        return this;
    }

    public virtual void Destroy()
    {
    }

    public virtual string GetItemType()
    {
        return "";
    }

    public virtual string GetDescription()
    {
        return "";
    }
}

