using System;

namespace App
{
    public class SomeStaticDataProvider : Singleton<SomeStaticDataProvider>
    {
        public double PiNumber
        {
            get { return Math.PI; }
        }
    }
}