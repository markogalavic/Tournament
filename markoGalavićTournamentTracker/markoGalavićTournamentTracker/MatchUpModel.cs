using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićTournamentTracker
{
    public class MatchUpModel
    {
        public List<MatchUpEntryModel> Entries { get; set; }
        public TeamModel Winner { get; set; }
        public int MyProperty { get; set; }
    }
}
