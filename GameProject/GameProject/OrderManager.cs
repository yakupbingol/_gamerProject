﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOfferManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
