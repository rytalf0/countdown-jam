using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class representing a collection of measures with the same time signature and bpm
public class SongSection
{
    public int bpm;
    public Music.TimeSignature timeSignature;
    public int numberOfMeasures;

    public List<Measure> measures;
}