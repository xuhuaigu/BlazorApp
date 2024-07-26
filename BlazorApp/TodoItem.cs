namespace BlazorApp
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; }
    }

    public class Test
    {
        public int rnd = new Random().Next(100, 200);
        public List<int> number1 = new List<int>() { new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
                                                    new Random().Next(100, 200),
        };

        public object[] DATA = new object[] 
        {
            new  { year = "1991", value = new Random().Next(100, 200)},
            new  { year = "1992", value = new Random().Next(100, 200) },
            new  { year = "1993", value = new Random().Next(100, 200) },
            new  { year = "1994", value = new Random().Next(100, 200) },
            new  { year = "1995", value = new Random().Next(100, 200) },
            new  { year = "1996", value = new Random().Next(100, 200) },
            new  { year = "1997", value = new Random().Next(100, 200) },
            new  { year = "1998", value = new Random().Next(100, 200) },
            new  { year = "1999", value = new Random().Next(100, 200) },
        };
    }
}
