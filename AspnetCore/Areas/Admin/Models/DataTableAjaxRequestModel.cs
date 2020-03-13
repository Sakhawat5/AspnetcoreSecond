﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore.Areas.Admin.Models
{
    public class DataTableAjaxRequestModel
    {
        private HttpRequest _request;

        private int Start
        {
            get
            {
                return Convert.ToInt32(_request.Query["start"]);
            }
        }
        public int Length
        {
            get
            {
                return Convert.ToInt32(_request.Query["length"]);
            }
        }
        public string SearchText
        {
            get
            {
                return _request.Query["search[value]"];
            }
        }
        public int sortingCols;
        public DataTableAjaxRequestModel(HttpRequest request)
        {
            _request = request;
        }
        public int PageIndex
        {
            get
            {
                if (Length > 0)
                    return (Start / Length) + 1;
                else
                {
                    return 1;
                }
            }
        }
        public int PageSize
        {
            get
            {
                if (Length == 0)
                    return 10;
                else
                    return Length;
            }
        }
        public static object EmptyResult
        {
            get
            {
                return new
                {
                    draw = 1,
                    recordsTotal = 0,
                    recordsFiltered = 0,
                    data = (new string[] { }).ToArray()
                };
            }
        }
    }
}
