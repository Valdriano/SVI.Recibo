using SVI.SQLite.CodeFirst.Public.Entities;
using System;

namespace SVI.Recibo.Infra
{
    public class CustomHistory : IHistory
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Context { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
