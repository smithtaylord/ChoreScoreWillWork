using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScoreWillWork.Models;
public class Chore
{
    public Chore(string name, int effortLevel, string location, int id)
    {
        Id = id;
        Name = name;
        EffortLevel = effortLevel;
        Location = location;


    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int EffortLevel { get; set; }
    public bool IsComplete { get; private set; } = false;
    public string Location { get; set; }

    public void CompleteMe()
    {
        this.IsComplete = true;
    }
}