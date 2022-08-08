using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalPowerText : MonoBehaviour
{
    public TextMeshProUGUI SpiritStats;
    public void Start()
    {
        SpiritStats = gameObject.GetComponent<TextMeshProUGUI>();
        SpiritStats.text = ScoreCounter.TheType + " Spirit Summoned with " + ScoreCounter.ScoreNum.ToString() + " Power.";
        AddSpirit(ScoreCounter.TheType, ScoreCounter.ScoreNum);
    }
    List<SummonedSpirit> SpiritsSummoned = new List<SummonedSpirit>();
    void AddSpirit(string DynamType, int Power)
    {
        Debug.Log("Added to your Summoned Spirit.");
        SpiritsSummoned.Add(new SummonedSpirit { TypeofSpirit = DynamType, PowerofSpirit = Power });
        //SpiritManager.Save();
    }
}
public class SummonedSpirit
{
    public string TypeofSpirit;
    public int PowerofSpirit;
}