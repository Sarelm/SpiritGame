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
        Debug.Log("Is this saving it?");
        Spirits.SpiritsSummoned = SpiritsYouSummoned;
        XmlSerializer serializer = new XmlSerializer(typeof(SpiritList));
        FileStream stream = new FileStream(Application.persistentDataPath + "/Spirits/yourspirits.xml", FileMode.Create);
        serializer.Serialize(stream, Spirits);
        stream.Close();
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
    public void Save()
    {
        Debug.Log("It actually saved!!");
        instance.SaveSpirits(SpiritsSummoned);
    }
    public void Load()
    {
        Debug.Log("Here's those spirits you asked for.");
        SpiritsSummoned = instance.LoadSummonedSpirits();
    }
}
[System.Serializable]
public class SpiritList
{
    public List<SummonedSpirit> SpiritsSummoned = new List<SummonedSpirit>();
}
