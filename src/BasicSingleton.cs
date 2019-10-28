using System;

namespace SingletonDesignPattern
{
    public class BasicSingleton
    {        
        private static BasicSingleton instance;
        
        private BasicSingleton(){ }

        public static BasicSingleton GetInstance()
        {
            if(instance == default(BasicSingleton)){
                 instance = new BasicSingleton();
            }

            return instance;
        }
    }
}
