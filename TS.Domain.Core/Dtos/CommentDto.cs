﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class CommentDto
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        #endregion Properties

        #region Navigation properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        #endregion Navigation properties
    }
}
