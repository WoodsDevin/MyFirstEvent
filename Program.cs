    public class Program // Subscriber class
    {
        public static void Main(string[] args)
        {
            // Subscribe to the event by assigning the method you want called when the event is fired ( CallBack() ) to the event delegate
            PublisherClass pub = new PublisherClass();
            pub.TheEvent += OnDisplay;
            
            // Call 
            pub.DisplayData();
        }
        
        // Method that will be called whent the event is fired ( It was added to the event delegate )
        public static void OnDisplay()
        {
            Console.WriteLine("Psst.... The event was fired.");
        }
        
    }
    
