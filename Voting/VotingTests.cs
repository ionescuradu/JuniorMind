using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Voting
{
    [TestClass]
    public class VotingTests
    {

        [TestMethod]
        public void PollsFirstTest()
        {
            CollectionAssert.AreEqual(new Candidate[2] { new Candidate("Andreea", 50), new Candidate("Radu", 40) }, Election(new PollingStation[] { new PollingStation(new Candidate[2] { new Candidate("Andreea", 20), new Candidate("Radu", 15) }), new PollingStation(new Candidate[2] { new Candidate("Andreea", 30), new Candidate("Radu", 25) }) }));
        }

        public struct Candidate
        {
            public string name;
            public int votes;

            public Candidate(string name, int votes)
            {
                this.name = name;
                this.votes = votes;
            }
        }

        public struct PollingStation
        {
            public Candidate[] station;
            public PollingStation(Candidate[] station)
            {
                this.station = station;
            }
        }

        Candidate[] Election(PollingStation[] givenVotes)
        { 
            var finalPolls = new Candidate[] { new Candidate("Radu", 0), new Candidate("Andreea", 0) };
            for (int i = 0; i < givenVotes.Length; i++)
            {
                for (int j = 0; j < givenVotes[i].station.Length; j++)
                {
                    for (int k = 0; k < finalPolls.Length; k++)
                        if (finalPolls[k].name == givenVotes[i].station[j].name)
                        {
                            finalPolls[k].votes += givenVotes[i].station[j].votes;
                        }
                }
            }
            var sortingIndex = 0;
            var aux = new Candidate();
            while (sortingIndex != finalPolls.Length - 1)
            {
                var max = finalPolls[sortingIndex].votes;
                var index = sortingIndex;
                for (int i = sortingIndex; i < finalPolls.Length; i++)
                {
                    if (finalPolls[i].votes > max)
                    {
                        index = i;
                    }
                }
                aux.name = finalPolls[sortingIndex].name;
                aux.votes = finalPolls[sortingIndex].votes;
                finalPolls[sortingIndex].name = finalPolls[index].name;
                finalPolls[sortingIndex].votes = finalPolls[index].votes;
                finalPolls[index].name = aux.name;
                finalPolls[index].votes = aux.votes;
                sortingIndex += 1;
            }
            return finalPolls;
        }

    }
}
