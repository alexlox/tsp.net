using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 1! Value:" + e.Value);
            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 2! Value:" + e.Value);

            p.Raise();

            int numarNaturalDat = 50000;
            PrimeNumbers primeNumbers = new PrimeNumbers();

            Thread thread1 = new Thread(() => primeNumbers.getLesserPrimeNumber(numarNaturalDat, 0));
            Thread thread2 = new Thread(() => primeNumbers.getLesserPrimeNumber(numarNaturalDat, 1));

            try
            {
                thread1.Start();
                Console.WriteLine("Startfir:" + thread1.GetHashCode() + " Time: " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Numar natural dat = " + numarNaturalDat);
                thread2.Start();
                Console.WriteLine("Startfir:" + thread2.GetHashCode() + " Time: " + DateTime.Now.ToString("HH:mm:ss:ffff") + " Numar natural dat = " + numarNaturalDat);
            } catch (Exception ex) when (ex is ThreadStateException || ex is OutOfMemoryException) {
                Console.WriteLine("Exception!");
            }
        }
    }

    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }

        public MyEventArgs(int value)
        {
            Value = value;
        }
    }

    public class Pub
    {
        public event EventHandler<MyEventArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyEventArgs(33));
        }
    }

    class PrimeNumbers
    {
        public int getLesserPrimeNumber(int n, int alg)
        {
            int ret = -1;
            switch(alg)
            {
                case 0:
                    ret = badLesserPrimeAlg(n);
                    Console.WriteLine("Bad algorithm finished with value " + ret + " at " + DateTime.Now.ToString("HH:mm:ss:ffff"));
                    break;
                case 1:
                    ret = goodLesserPrimeAlg(n);
                    Console.WriteLine("Good algorithm finished with value " + ret + " at " + DateTime.Now.ToString("HH:mm:ss:ffff"));
                    break;
                default:
                    return -1;
            }

            return ret;
        }

        protected int badLesserPrimeAlg(int n)
        {
            int foundPrime = -1;

            for (int i = 0; i < n; i++)
            {
                if (isPrime(i))
                {
                    foundPrime = i;
                }
            }

            return foundPrime;
        }

        protected int goodLesserPrimeAlg(int n)
        {
            int foundPrime;

            for (int i = n; i > 0; i--)
            {
                if (isPrime(i))
                {
                    foundPrime = i;
                    return foundPrime;
                }
            }

            return -1;
        }

        protected bool isPrime(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
