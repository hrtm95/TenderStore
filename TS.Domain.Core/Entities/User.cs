﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class User
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        #endregion Properties

        #region Navigation properties
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<SoldGoods> SoldGoods { get; set; }
        public ICollection<AuctionInformation> AuctionInformation { get; set; }
        public ICollection<Order> Order { get; set; }
        #endregion Navigation properties
    }
}
