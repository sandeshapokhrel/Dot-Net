//create a class library which cointains following Fields name, Address,LibraryAdmin now raise an event using
//brodcaster/subscriber model as, the state change in any library object, for this time consider only the state
//of libraryAdmin

using System;

namespace LibraryNamespace
{
    public class LibraryAdminChangedEventArgs : EventArgs
    {
        public string OldAdmin { get; set; }
        public string NewAdmin { get; set; }

        public LibraryAdminChangedEventArgs(string oldAdmin, string newAdmin)
        {
            OldAdmin = oldAdmin;
            NewAdmin = newAdmin;
        }
    }

    public class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }

        private string _libraryAdmin;

        public string LibraryAdmin
        {
            get { return _libraryAdmin; }
            set
            {
                if (_libraryAdmin != value)
                {
                    OnLibraryAdminChanged(new LibraryAdminChangedEventArgs(_libraryAdmin, value));
                    _libraryAdmin = value;
                }
            }
        }

        // Event to notify subscribers about changes
        public event EventHandler<LibraryAdminChangedEventArgs> LibraryAdminChanged;

        // Protected virtual method to raise the event
        protected virtual void OnLibraryAdminChanged(LibraryAdminChangedEventArgs e)
        {
            LibraryAdminChanged?.Invoke(this, e);
        }
    }

    // Subscriber class to handle the event
    public class Subscriber
    {
        public void Subscribe(Library library)
        {
            library.LibraryAdminChanged += HandleLibraryAdminChanged;
        }

        private void HandleLibraryAdminChanged(object sender, LibraryAdminChangedEventArgs e)
        {
            Console.WriteLine($"LibraryAdmin changed from {e.OldAdmin} to {e.NewAdmin}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library
            {
                Name = "Sandesha Library",
                Address = "123 Lane",
                LibraryAdmin = "Harry"
            };

            // Create a subscriber and subscribe to the LibraryAdminChanged event
            var subscriber = new Subscriber();
            subscriber.Subscribe(library);

            // Change LibraryAdmin, which should trigger the event
            library.LibraryAdmin = "Sandesha";
            library.LibraryAdmin = "Smith";
        }
    }
}
