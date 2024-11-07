﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class nhap_hang_sql_BLL
    {
        nhap_hang_sql_DAL data;
        public nhap_hang_sql_BLL()
        {
            data = new nhap_hang_sql_DAL();
        }
        public IQueryable get_all_nhap_hang()
        {
            return data.get_all_nhap_hang();
        }
        public IQueryable<dynamic> get_nhap_hang_by_id(int id)
        {
            return data.get_nhap_hang_by_id(id);
        }
        public bool nhap_hang_add(nhap_hang s, List<chi_tiet_nhap_hang> a)
        {
            return data.nhap_hang_add(s,a);
        }
    }
}