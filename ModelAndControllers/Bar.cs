using System;

namespace ModelAndControllers
{
    public class Bar: EntityBase<Guid>
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}