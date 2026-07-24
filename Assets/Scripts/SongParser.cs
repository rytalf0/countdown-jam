using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class SongParser : MonoBehaviour
{
    public TextAsset songJSON;
    public GameObject longRestPrefab;
    public GameObject measurePrefab;

    public RectTransform contentTransform;

    private SongData songData;

    void Awake()
    {
        songData = JsonUtility.FromJson<SongData>(songJSON.text);
    }

    void GenerateSheetMusic()
    {
        foreach (var section in songData.songSections)
        {
            if (section.measures == null) //it's a long rest
            {
                var longRestGO = Instantiate(longRestPrefab, contentTransform);
                longRestGO.GetComponentInChildren<TextMeshPro>().text = section.numberOfMeasures.ToString();
            }
            else if (section.measures.Count == 1) //it's a one-off or repeated measure
            {
                for (int i = 0; i < section.numberOfMeasures; i++)
                {
                    var measure = Instantiate(measurePrefab, contentTransform);
                    measure.GetComponentInChildren<MeasureBuilder>().BuildMeasure(section.measures[i]);
                }
            }
        }
    }
}