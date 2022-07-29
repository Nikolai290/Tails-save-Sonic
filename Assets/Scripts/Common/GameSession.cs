namespace Common
{
    public class GameSession
    {
        public int PlayerHealth { get; set; } = 3;
        public bool Pause { get; set; }
        public bool IsAlive => PlayerHealth > 0;
    }
}