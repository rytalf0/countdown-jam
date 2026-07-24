using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class to de-serialize the song data from the json file
public class SongData 
{
    public string songName;
    public string arranger;
    public string originalArtist;
    public string songLength;
    public int baseBPM;

    public List<SongSection> songSections;
}
