namespace EventApp12032022
{
    public class EventDemo
    {
        public void Demo1()
        {
            var cat = new Cat() { Id = 1, Name = "Hırpıt", Health = 100 };
            cat.OnHealthChanaged += CatOnHealthChanaged;
            cat.OnHealthChanaged += CatIsDead;
            cat.Health = 200;
            for (int i = 0; i < 10; i++)
            {
                cat.Health -= 20;
            }
        }

        private void CatIsDead(object? sender, int e)
        {
            var cat = (Cat)sender;
            if (cat.Health <= 0)
                Console.WriteLine($"{cat.Name} is no longer alive :(");
        }

        private void CatOnHealthChanaged(object? sender, int health)
        {
            var cat = (Cat)sender;
            Console.WriteLine($"{cat.Name} has new health : {cat.Health}");
        }
    }
    public class Cat
    {
        private int health;
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Health
        {
            get => this.health;
            set
            {
                this.health = value;
                this.OnHealthChanaged?.Invoke(this, this.health);
            }
        }
        public event EventHandler<int> OnHealthChanaged;
    }
}
