namespace Com.AppDellaFresca.Bus.Model.Games;

public interface IAddGameRequest
{
    public DateTime Date { get; set; }
    public IPlayerData[] PlayerData { get; set; }
}
