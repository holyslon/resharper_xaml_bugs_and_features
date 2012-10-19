using System;

namespace App
{
    public class Singleton<T> where T : new()
    {
         private readonly static Lazy<T> InstanceImpl = new Lazy<T>(() => new T());

        public static T Instance
        {
            get { return InstanceImpl.Value; }
        }
    }
}