namespace Oppgave_intermediate;

public interface IMyGenericInterface<E>
    {
        void Add(E item); //method to add an item
        E Get(int index); //method to get an item by index
        int Count { get; } //property to get the number of items
    }
    // This interface says that any class that implements this interface must have 
    // an Add method to add an item of type E
    // It must have a Get method to retrieve an item of type E by its index
    // It must have a Count property to return the number of items