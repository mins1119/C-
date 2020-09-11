using System;
using System.Net.Http.Headers;
using System.Threading;

namespace WaitPulseTest
{
    class Counter
    {
        const int LOOP_COUNT = 10000; //100번 반복하겠다
        readonly object thisLock; // 열쇠객체
        bool lockedCount = false; //조건, 이걸로 increase 아니면 decrease 하나밖에 못돔

        private int count; //더해지고 빼질 카운트
        public int Count //프로퍼티
        {
            get { return count; }
        }
        public Counter()
        {
            thisLock = new object(); //열쇠 초기화
            count = 0;      //카운트 초기화
        }
        public void Increase()
        {
            int loopCount = LOOP_COUNT; //increase의 지역변수 어쨋든 100번을돌겠다.
            while (loopCount-- > 0)
            {
                lock (thisLock) //increase든 decrease든 하나의 스레드밖에 실행을 못함
                {
                    count++;
                    Console.WriteLine($"increase : {count}");
                }
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT; //decrese의 지역변수 어쨋든 100번을돌겠다.
            while (loopCount-- > 0)
            {
                lock (thisLock)  //increase든 decrease든 하나의 스레드밖에 실행을 못함
                {
                  
                    count--;
                    

                    Console.WriteLine($"decrease : {count}");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));
            Thread incThread1 = new Thread(new ThreadStart(counter.Increase));
            Thread decThread1 = new Thread(new ThreadStart(counter.Decrease));
            Thread incThread2 = new Thread(new ThreadStart(counter.Increase));
            Thread decThread2 = new Thread(new ThreadStart(counter.Decrease));


            incThread.Start();
            decThread.Start(); 
            incThread1.Start();
            decThread1.Start();
            incThread2.Start();
            decThread2.Start();

            incThread.Join();
            decThread.Join();
            incThread1.Join();
            decThread1.Join();
            incThread2.Join();
            decThread2.Join();
            Console.WriteLine(counter.Count);
        }
    }
}
