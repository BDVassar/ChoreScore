using ChoreScore.Enums;

namespace ChoreScore.Models;

public class Chore
{

  public Guid Id { get; set; }
  public string name { get; set; }
  public string description { get; set; }
  public Chorepriority priority { get; set; }

  public Chore(string name, Chorepriority priority)
  {
    this.Id = Guid.NewGuid();
    this.name = name;
    this.priority = priority;

  }

}
