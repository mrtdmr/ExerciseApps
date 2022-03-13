namespace AsynchronousApp1
{
    public class AsyncTasks
    {
        public async Task Download()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("https://www.google.com/");
            await Task.Delay(5000);
            Topla();
            Console.WriteLine("İndirme tamamlandı");
            result.ToString();
        }
        public void Topla()
        {
            Console.WriteLine("Toplama İşlemi Yapıldı.");
        }
    }
}
