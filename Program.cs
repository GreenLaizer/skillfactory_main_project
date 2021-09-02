using System;
using static skillfactory_main_project.Program;

namespace skillfactory_main_project
{
    class Program
    {

        abstract class Client<T>
        {
            public string Number { get; set; }
            public int Pincode { get; set; }
            public string FIO { get; set; }
            public int Money { get; set; }
            

            

            public Client(string number, int pincode, string fio, int money)
            {
                this.Number = number;
                this.Pincode = pincode;
                this.FIO = fio;
                this.Money = money;
               
            }

            public Client()
            {
            }
        }
        abstract class Settings
        {
            public Settings()
            {

            }
        }
      
         public abstract class Delivery<T>
        {
            public virtual string Address { get; set; }

            public virtual string Name { get; set; }
            public virtual string LastName { get; set; }

            

            public Delivery(string name, string lastname, string address)
            {
                Name = name;
                LastName = lastname;
                Address = address;
                
            }
            public abstract  void Show();
          
        }

        class HomeDelivery<T> : Delivery<T>
        {
            public override string Address { get; set; }

            public override string Name { get; set; }
            public override string LastName { get; set; }

            public DateTime ArrivalDate;
            public HomeDelivery(string name, string lastname,string Address, DateTime arrivalDate) : base(name, lastname, Address)
            {
                this.Address = Address;
                this.ArrivalDate = arrivalDate;
            }
            public override void Show()
            {
                Console.WriteLine(" name = {0} LastName = {1} Address = {2} ArrivalDate {3}", Name, LastName, Address, ArrivalDate);
              
            }

        }

        class PickPointDelivery<T> : Delivery<T>
        {
            public override string Address { get; set; }

            public override string Name { get; set; }
            public override string LastName { get; set; }

            public DateTime ArrivalDate;

            public PickPointDelivery(string name, string lastname, string Address, DateTime arrivaleDate) : base(name, lastname, Address)
            {
                this.Address = Address;
                this.ArrivalDate = arrivaleDate;
                
            }
            public override void Show()
            {
                Console.WriteLine(" name = {0} LastName = {1} Address = {2} ArrivalDate {3}", Name, LastName, Address, ArrivalDate);
            }


        }

        class ShopDelivery<T>: Delivery<T>
        {
            public override string Address { get; set; }

            public override string Name { get; set; }
            public override string LastName { get; set; }

            public DateTime ArrivalDate;

            public ShopDelivery(string name, string lastname, string Address) : base(name, lastname, Address)
            {
                this.Address = Address;
            }
            public override void Show()
            {
                Console.WriteLine(" name = {0} LastName = {1} Address = {2} ArrivalDate {3}", Name, LastName, Address, ArrivalDate);
            }

        }

       public class Order<TDelivery,
        TStruct> where TDelivery : Delivery<TDelivery>
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

        }

        protected class OrderCollection<T>
        {
            int _size;
            int[] IntArr;

            public OrderCollection(int size)
            {
                IntArr = new int[size];
                _size = size;
            }
            public int this[int index]
            {
                get
                {
                    if ((index >= 0) && (index < Size))
                    {
                        return IntArr[index];
                    }
                    else
                    {
                        return int.MaxValue;
                    }
                }

                set
                {
                    if ((index >= 0) && (index < Size))
                    {
                        IntArr[index] = value;
                    }
                }

            }
            public int Size
            {
                get { return _size; }
            }


        }

       private  class ToHexIndexator
        {
            public string this[int index]
            {
                get
                {
                    string result = Convert.ToString(index, 16);
                    return result;
                }
            }
        }


        static void Main(string[] args)
        {
            
            

           
        }
    }
}
