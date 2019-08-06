﻿using System;

namespace SingletonDesignPattern
{
    public class ThreadSafeSingleton
    {
        public string Name => "Singleton";
        private static ThreadSafeSingleton instance;
        private static readonly object singletonlock = new object();  

        
        private ThreadSafeSingleton(){ }

        public static ThreadSafeSingleton GetInstance()
        {
            lock (singletonlock)  
            {  
                if(instance == default(ThreadSafeSingleton))
                {
                    instance = new ThreadSafeSingleton();
                }

                return instance;
            }          
        }
    }
}
