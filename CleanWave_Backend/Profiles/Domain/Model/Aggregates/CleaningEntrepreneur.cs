using CleanWave_Backend.Profiles.Domain.Model.Commands;

namespace CleanWave_Backend.Profiles.Domain.Model.Aggregates;

public partial class CleaningEntrepreneur
{
    public int Id { get; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Username { get; private set; }

    public CleaningEntrepreneur(string name, string email, string username)
    {
        Name = name;
        Email = email;
        Username = username;
    }

    public CleaningEntrepreneur(CreateCleaningEntrepreneurCommand command)
    {
        Name = command.Name;
        Email = command.Email;
        Username = command.Username;
    }
}