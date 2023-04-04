﻿using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.AppointmentDtos
{
    public class AppointmentListDto:DtoGetBase
    {
        public IList<Appointment> Appointments{ get; set; }
        public IList<AppointmentListWithRelatedTable> AppointmentListWithRelatedTables { get; set; }

    }
}
