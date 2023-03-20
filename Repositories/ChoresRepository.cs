using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScoreWillWork.Repositories;
public class ChoresRepository
{
    private List<Chore> dbChores = new List<Chore>();
    public ChoresRepository()
    {
        dbChores.Add(new Chore("Take out the trash", 2, "Kitchen", 1));
        dbChores.Add(new Chore("Pick up stick", 5, "Backyard", 2));
        dbChores.Add(new Chore("Clean out Gutters", 8, "Roof", 3));
    }

    internal List<Chore> GetAllChores()
    {
        return dbChores;
    }

    internal Chore GetOneChore(int id)
    {
        Chore chore = dbChores.Find(chore => chore.Id == id);
        return chore;
    }
    internal Chore CreateChore(Chore choreData)
    {
        choreData.Id = dbChores[dbChores.Count - 1].Id + 1;
        dbChores.Add(new Chore(choreData.Name, choreData.EffortLevel, choreData.Location, choreData.Id));
        return choreData;
    }

    internal bool RemoveChore(int choreId)
    {
        int count = dbChores.RemoveAll(chore => chore.Id == choreId);
        return count > 0;
    }
}
