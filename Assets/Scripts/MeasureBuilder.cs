using UnityEngine;

//instantiate notes and rests into a horizontal layout group.
public class MeasureBuilder : MonoBehaviour
{
    public GameObject fourfour;
    public GameObject wholeRest;
    public GameObject halfRest;
    public GameObject quarterRest;
    public GameObject eighthRest;
    public GameObject quarterNote;
    public GameObject eighthNote;
    
    public RectTransform contentTransform;

    public void BuildMeasure(Measure sectionMeasure)
    {
        foreach (var evnt in sectionMeasure.events)
        {
            if (evnt.e == 0) //it's a note
            {
                var note = evnt.b == Music.BeatType.Eighth
                    ? Instantiate(eighthNote, contentTransform) //todo: joined 8th notes?? 
                    : Instantiate(quarterNote, contentTransform);
            }
            else //it's a rest
            {
                switch (evnt.b)
                {
                    case Music.BeatType.Eighth:
                        Instantiate(eighthNote, contentTransform);
                        break;
                    case Music.BeatType.Quarter:
                        Instantiate(quarterRest, contentTransform);
                        break;
                    case Music.BeatType.Half:
                        Instantiate(halfRest, contentTransform);
                        break;
                    case Music.BeatType.Whole:
                        Instantiate(wholeRest, contentTransform);
                        break;
                }
            }
        }
    }
}