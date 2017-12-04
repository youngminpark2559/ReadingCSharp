using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Create a console application FunWithObservableCollection.
//c Updata Main() to use ObservableCollection<>.
//c Update people_CollectionChanged() to use NotifyCollectionChangedEventArgs object with retrieving Action, OldItems, NewItems.

namespace FunWithObservableCollection
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Make a collection to observe and add a few Person objects.
            ObservableCollection<Person> people = new ObservableCollection<Person>()
                {
                  new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
                  new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 },
                };

            // Wire up the CollectionChanged event.
            people.CollectionChanged += people_CollectionChanged;
        }

        static void people_CollectionChanged(object sender,  System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // What was the action that caused the event?
            Console.WriteLine("Action for this event: {0}", e.Action);

            // They removed something.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            // They added something.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Now show the NEW items that were inserted.
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}

