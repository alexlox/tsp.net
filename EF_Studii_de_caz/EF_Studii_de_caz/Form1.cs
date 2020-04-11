﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Studii_de_caz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TestSelfReference()
        {
            using (ModelSelfReferences context = new ModelSelfReferences())
            {
                SelfReference self1 = new SelfReference()
                {
                    Name = "name1"
                };

                SelfReference self2 = new SelfReference()
                {
                    Name = "name2"
                };
                self2.ParentSelfReference = self1;

                SelfReference self3 = new SelfReference()
                {
                    Name = "name3"
                };
                self3.References.Add(self1);

                context.SelfReferences.Add(self1);
                context.SelfReferences.Add(self2);
                context.SelfReferences.Add(self3);

                context.SaveChanges();

                var items = context.SelfReferences;

                Label label;
                int y = 25;

                foreach (var x in items)
                {
                    y += 25;
                    label = new Label();
                    label.Location = new Point(25, y);
                    label.Text = x.SelfReferenceId + " " + x.Name + " | " + x.ParentSelfReferenceId;
                    if (x.ParentSelfReference != null)
                    {
                        label.Text += " " + x.ParentSelfReference.Name;
                    }
                    this.Controls.Add(label);
                }
            }
        }

        public void Test2()
        {
            using (var context = new EF6RecipesContext())
            {
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
            using (var context = new EF6RecipesContext())
            {
                Label label;
                int y = 25;

                foreach (var p in context.Products)
                {
                    y += 25;
                    label = new Label();
                    label.Location = new Point(25, y);
                    label.Text = p.SKU + " " + p.Description + " " + p.Price.ToString("C") + " " + p.ImageURL;
                    this.Controls.Add(label);
                }
            }
        }

        public void Test3()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new SelectiveColumnsModel())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }
            using (var context = new SelectiveColumnsModel())
            {
                Label label;
                TextBox text;
                int y = 25;

                foreach (var photo in context.Photographs)
                {
                    y += 25;
                    text = new TextBox();
                    text.Location = new Point(25, y);
                    text.Width = 150;
                    text.Text = "Photo: " + photo.Title + " , ThumbnailSize" + photo.ThumbnailBits.Length + " bytes";
                    this.Controls.Add(text);
                    // explicitly load the "expensive" entity,
                    context.Entry(photo)
                        .Reference(p => p.PhotographFullImage).Load();
                    y += 25;
                    text = new TextBox();
                    text.Location = new Point(25, y);
                    text.Width = 150;
                    text.Text = "Full Image Size: " + photo.PhotographFullImage.HighResolutionBits.Length;
                    this.Controls.Add(text);
                }
            }
        }

        public void Test4()
        {
            using (var context = new HierarchyModel())
{
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber =
                "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber =
                "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }
            using (var context = new HierarchyModel())
{
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }

        public void Test5()
        {
            using (var context = new HierarchyModel2())
{
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName =
                "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary = 62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName =
                "Jones",
                    Wage = 8.75M
                };
                context.Employees.Add(hourly);
                context.SaveChanges();
            }
            using (var context = new HierarchyModel2())
{
                Console.WriteLine("--- All Employees ---");
                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    fullTime ? "Full Time" : "Hourly");
                }
                Console.WriteLine("--- Full Time ---");
                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                }
                Console.WriteLine("--- Hourly ---");
                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    Console.WriteLine("{0} {1}", hourly.FirstName,
                    hourly.LastName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TestSelfReference();
            //Test2();
            //Test3();
            //Test4();
            Test5();
        }
    }
}
