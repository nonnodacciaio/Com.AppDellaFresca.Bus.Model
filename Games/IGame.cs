namespace Com.AppDellaFresca.Bus.Model.Games;

public interface IGame
{
    int Id { get; set; }
    DateTime Date { get; set; }
    int[] PlayersIds { get; set; }
    double? Result { get; set; }
}
