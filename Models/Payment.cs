
using System;

namespace Conductor.Models
{
    public class Payment
    {
        public Payment()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Payer { get; set; }
        public string Receiver { get; set; }
        public decimal Amount { get; set; }
    }
}