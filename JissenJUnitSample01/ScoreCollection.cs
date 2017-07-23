using System.Collections.Generic;
using System.Linq;

namespace JissenJUnitSample
{
    public class ScoreCollection
    {
        private List<Scoreable> scores = new List<Scoreable>();





        public void Add( Scoreable scoreable )
        {
            scores.Add( scoreable );
        }





        public int arithmeticMean()
        {
            var total = scores.Select( scoreable => scoreable.GetScore() ).Sum();
            return total / scores.Count;
        }
    }
}
