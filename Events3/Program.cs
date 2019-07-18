using System;

namespace Events3
{
    class Program
    {
        /// <summary>
        /// Event publisher için 3 adet nesneye ihtiyaç vardır: Delegate, delegate tipinden bir ebet ve bir metod. 
        /// </summary>
        static int score = 0;
        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();
            shooter.ShotsFired += AddScore;
            shooter.ShotsFired += KilledEnemy;
            shooter.OnShoot();
        }
        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            var tempSender = sender as Shooter;
            Console.WriteLine($"I killed an enemy at time {e.TimeOfKill}! And my name is {tempSender.Name}");
            //Console.WriteLine($"I killed an enemy! And my name is : {((Shooter)sender).Name}");
            Console.WriteLine($"My score is {score}.");
        }
        public static void AddScore(object sender,EventArgs e) {
            score++;
        }
    }
    
}
 