using System;
using System.Collections.Generic;
using System.Globalization;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First\n");

            // TestPerson();
            // TestOneToMany();
            TestManyToMany();
        }
        static void TestPerson()
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Middle Name:");
            string middleName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Telephone:");
            string telephone = Console.ReadLine();

            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MiddleName = middleName,
                    TelephoneNumber = telephone
                };

                context.People.Add(p);
                context.SaveChanges();

                var items = context.People;

                foreach (var x in items)
                {
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                }
            }
        }

        private struct OrderType
        {
            public int TotalValue;
            public DateTime Date;
        }

        static void TestOneToMany()
        {
            Console.WriteLine("One to many association");

            Console.WriteLine("Customer Name:");
            string custName = Console.ReadLine();

            Console.WriteLine("Customer City:");
            string custCity = Console.ReadLine();

            Console.WriteLine("How many orders?");
            int noOfOrders = int.Parse(Console.ReadLine());

            List<OrderType> orders = new List<OrderType>();
            OrderType order;

            Console.WriteLine("");

            for (int i = 0; i < noOfOrders; i++)
            {
                Console.WriteLine("Order {0}", i + 1);

                Console.WriteLine("Total Value:");
                order.TotalValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Date (dd/MM/yyyy):");
                order.Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("");

                orders.Add(order);
            }

            using (ModelOneToManyContainer context = new ModelOneToManyContainer())
            {
                Customer c = new Customer()
                {
                    Name = custName,
                    City = custCity
                };

                context.Customers.Add(c);

                for (int i = 0; i < noOfOrders; i++)
                {
                    Order or = new Order()
                    {
                        TotalValue = orders[i].TotalValue,
                        Date = orders[i].Date,
                        Customer = c
                    };

                    context.Orders.Add(or);
                }

                context.SaveChanges();

                var items = context.Customers;

                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);

                    foreach (var ox in x.Orders)
                    {
                        Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                    }
                }
            }
        }
        static void TestManyToMany()
        {
            Console.WriteLine("Many to many association");

            using (ModelManyToManyContainer context = new ModelManyToManyContainer())
            {
                Album album1 = new Album()
                {
                    AlbumName = "Album 1"
                };

                Album album2 = new Album()
                {
                    AlbumName = "Album 2"
                };

                Album album3 = new Album()
                {
                    AlbumName = "Album 3"
                };

                Artist artist1 = new Artist()
                {
                    FirstName = "Mr.",
                    LastName = "Artist 1"
                };

                Artist artist2 = new Artist()
                {
                    FirstName = "Mr.",
                    LastName = "Artist 2"
                };

                album1.Artists.Add(artist1);
                album1.Artists.Add(artist2);

                artist2.Albums.Add(album2);
                artist2.Albums.Add(album3);

                context.Albums.Add(album1);
                context.Albums.Add(album2);
                context.Albums.Add(album3);
                context.Artists.Add(artist1);
                context.Artists.Add(artist2);

                context.SaveChanges();

                var artists = context.Artists;

                foreach (var x in artists)
                {
                    Console.WriteLine("Artist : {0} {1}", x.FirstName, x.LastName);

                    foreach (var ox in x.Albums)
                    {
                        Console.WriteLine("\tAlbum: {0}", ox.AlbumName);
                    }
                }
            }
        }
    }
}
