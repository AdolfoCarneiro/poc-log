﻿namespace Application
{
    public class AnyService : IAnyService
    {
        public int DoAnithing()
        {
            var a = 1;
            var b = 2;
            var c = a + b;
            return c;
        }
    }
}
