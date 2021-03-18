using System;

namespace Carguero.Domain.Entities
{
    public class GameResult
    {
        public int Id { get; set; }
        public long PlayerID { get; set; }
        public long GameID { get; set; }
        public long Win { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
