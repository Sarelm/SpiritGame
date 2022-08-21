using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System;

public class SpiritManager : MonoBehaviour
{
    public static SpiritManager instance;
    public SpiritList Spirits;
    void Awake()
    {
        instance = this;
        if (!Directory.Exists(Application.persistentDataPath + "/Spirits/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Spirits/");
        }
    }
    public void SaveSpirits(List<SummonedSpirit> SpiritsYouSummoned)
    {
        Spirits.SpiritsSummoned = SpiritsYouSummoned;
        XmlSerializer serializer = new XmlSerializer(typeof(SpiritList));
        FileStream stream = new FileStream(Application.persistentDataPath + "/Spirits/yourspirits.xml", FileMode.Create);
        serializer.Serialize(stream, Spirits);
        stream.Close();
    }

    internal static void Save()
    {
        throw new NotImplementedException();
    }

    public List<SummonedSpirit> LoadSummonedSpirits()
    {
        if(File.Exists(Application.persistentDataPath + "/Spirits/yourspirits.xml"))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SpiritList));
            FileStream stream = new FileStream(Application.persistentDataPath + "/Spirits/yourspirits.xml", FileMode.Open);
            Spirits = serializer.Deserialize(stream) as SpiritList;
        }
        return Spirits.SpiritsSummoned;
    }
    List<SummonedSpirit> SpiritsSummoned;
    public void Save(List<SummonedSpirit> SpiritsSummoned)
    {
        Debug.Log("Saving Spirit List Now");
        instance.SaveSpirits(SpiritsSummoned);
    }
    public void Load()
    {
        SpiritsSummoned = instance.LoadSummonedSpirits();
    }
}
[System.Serializable]
public class SpiritList
{
    public List<SummonedSpirit> SpiritsSummoned = new List<SummonedSpirit>();
}
