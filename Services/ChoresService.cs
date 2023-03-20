using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScoreWillWork.Services;
public class ChoresService
{
    private readonly ChoresRepository _repo;
    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    public List<Chore> GetAllChores()
    {
        return _repo.GetAllChores();
    }

    internal Chore GetOneChore(int id)
    {
        Chore chore = _repo.GetOneChore(id);
        if (chore == null) throw new Exception($"No cat at id:{id}");
        return chore;
    }
    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetOneChore(choreId);
        bool result = _repo.RemoveChore(choreId);
        if (!result) throw new Exception("Didn't delete any chores for some reason");
        return $"{chore.Name} was not needed to be done as a chore afterall.";
    }

    internal Chore CompleteChore(int id)
    {
        Chore chore = this.GetOneChore(id);
        chore.CompleteMe();
        return chore;
    }
}