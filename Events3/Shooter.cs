using System;
using System.Threading;

namespace Events3
{
    public class Shooter
    {
        private Random rng = new Random();
        //public delegate void ShootingHandler(object sender, ShotsFiredEventArgs e);
        //public event ShootingHandler ShotsFired;
        public event EventHandler<ShotsFiredEventArgs> ShotsFired;
        public string Name { get; set; } = "Billy";
        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    ShotsFired?.Invoke(this, new ShotsFiredEventArgs(DateTime.Now)); 
                }
                else
                {
                    Console.WriteLine("I missed!");
                }
                Thread.Sleep(500);
            }
        }
    }
}
