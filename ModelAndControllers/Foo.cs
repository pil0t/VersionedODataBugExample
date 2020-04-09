using System;

namespace ModelAndControllers
{
    public class Foo: EntityBase<Guid>
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}