﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Data.Entity
{
    public class Groups
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UsersId { get; set; }

        public Users Users { get; set; }

        public ICollection<Students> Students { get; set; }

    }
}
