using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct TrackData
    {
        // The title or name of the track.
        public string trackName;
        // The name of the artist.
        public string artistName;
        // The name of the album.
        public string albumName;

        // The length of the track in seconds.
        public float trackDuration;

        // The position of the track in an album or single.
        public int trackNumber;

        public TrackData(string track)
        {
            trackName = track; artistName = ""; albumName = "";
            trackDuration = 0; trackNumber = 0;
        }
        public TrackData(string track, float duration)
        {
            trackName = track; trackDuration = duration;
            artistName = ""; albumName = "";
            trackNumber = 0;
        }
        public TrackData(string track, float duration, string artist)
        {
            trackName = track; trackDuration = duration; artistName = artist;
            albumName = "";
            trackNumber = 0;
        }
        public TrackData(string track, float duration, string artist, string album)
        {
            trackName = track; trackDuration = duration; artistName = artist; albumName = album;
            trackNumber = 0;
        }
        public TrackData(string track, float duration, string artist, string album, int number)
        {
            trackName = track; trackDuration = duration; artistName = artist; albumName = album;
            trackNumber = number;
        }

        // Compares two tracks and returns true if all fields are identical.
        public static bool operator ==(TrackData lhs, TrackData rhs)
        {
            return lhs.trackName == rhs.trackName &&
                lhs.artistName == rhs.artistName &&
                lhs.albumName == rhs.albumName &&
                lhs.trackDuration == rhs.trackDuration &&
                lhs.trackNumber == rhs.trackNumber;
        }

        // Compares two tracks and returns true if any field is not identical.
        public static bool operator !=(TrackData lhs, TrackData rhs)
        {
            return !(lhs == rhs);
        }

        // Compares two tracks and returns true if all fields are identical.
        public override bool Equals(Object obj)
        {
            return obj is TrackData && this == (TrackData)obj;
        }
        // Performs a XOR op on all of the fields and returns the resulting value.
        public override int GetHashCode()
        {
            return trackName.GetHashCode() ^ artistName.GetHashCode() ^
                albumName.GetHashCode() ^ trackDuration.GetHashCode() ^ trackNumber.GetHashCode();
        }

        // Provides a one-liner text value of all of the strings.
        public override string ToString()
        {
            return String.Format("{0},    {1},    {2},    {3},    {4}", trackName, artistName, albumName, trackDuration, trackNumber);
        }
    }
}