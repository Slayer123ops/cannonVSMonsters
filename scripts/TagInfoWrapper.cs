using System;

[Serializable]
public class TagInfoWrapper
{
    public TagInfo[] tagInfos;

    public string GetTagForObject(string GOName)
    {
        foreach(TagInfo info in tagInfos)
        {
            if(info.partName.Equals(GOName))
                return info.tag;
        }

        return "";
    }
}
