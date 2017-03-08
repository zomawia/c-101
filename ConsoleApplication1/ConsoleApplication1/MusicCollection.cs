using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MusicCollection
    {
        // Stores all of the tracks relevant to this collection.
        private TrackData[] tracks;
        private int cursor = 0;

        private void Resize (int newSize)
        {
            TrackData[] temp = new TrackData[newSize];

            for (int i =0; i < tracks.Length; ++i)
            {
                temp[i] = tracks[i];
            }
            tracks = temp;
        }

        // Add a track the music collection and returns its position in the array
        public int AddTrack(TrackData track)
        {
            if (tracks == null)
            {
                tracks = new TrackData[1];
            }
            else if (cursor >= tracks.Length)
            {
                Resize(cursor + 1);
            }

            tracks[cursor] = track;
            int pos = cursor;
            cursor++;
            return pos;
        }

        private void Remove(int trackIndex)
        {
            for (int i = trackIndex + 1; i < tracks.Length; ++i)
            {

            }
        }

        // Remove a track by its index in the array
        public void RemoveTrack(int trackNumber)
        {
            tracks[trackNumber] = new TrackData();
        }
        // Calculates and returns the total runtime of the tracks in this collection
        public float GetTotalDuration()
        {
            float totalTime = 0;            
            for (int i = 0; i < tracks.Length; ++i)
            {
                totalTime += tracks[i].trackDuration;
            }
            return totalTime;
        }

        // Returns the total number of tracks in this collection
        public int GetTrackCount()
        {
            int total = 0;
            if (tracks.Length > 0)
            {
                for (int i = 0; i < tracks.Length; ++i)
                {
                    total++;
                }
            }
            return total;
        }

        // Returns the track at the given index in the array
        //public TrackData GetTrackAt(int trackNumber)
        //{
            
        //}
    }
}
