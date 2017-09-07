public class PublisherClass // Publisher class that defines and raises the event.
    {
        // Define event and delegate
        public delegate void Notify();
        public event         Notify TheEvent;
        public object Data = "This is my inner data.";
        
        public void DisplayData()
        {
            // Random stuff
            Console.WriteLine(Data.ToString());
            
            // Call the event as well.
            TheEvent();
        }
    }
