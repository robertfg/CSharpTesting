using System;
using System.Linq;

namespace TreehouseDefense
{
    public class Path
    {
        private MapLocation[] _pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            //this._path = pathLocations;
            _pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation) => _pathLocations.Contains(mapLocation);

        //public bool IsOnPath(MapLocation mapLocation)
        //{
        //    return Array.IndexOf(_path, mapLocation) >= 0;

        //    //throw new NotImplementedException();
        //}

        /*  *****   COPIED FROM DOWNLOADED WORKSPACE    *****   */
        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _pathLocations.Length) ? _pathLocations[pathStep] : null;
        }
    }
}