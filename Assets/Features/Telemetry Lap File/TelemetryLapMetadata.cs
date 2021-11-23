﻿namespace Perrinn424.TelemetryLapSystem
{
    [System.Serializable]
    public class TelemetryLapMetadata
    {
        public int fileFormatVersion;
        public int frequency;
        public int lapIndex;
        public float lapTime;
        public bool completed;
        public float completedSectors;
        public float[] sectorsTime;
        public string[] headers;
        public int count;
        public string csvFile;
    } 
}
