﻿namespace EFDatatable.Core
{
    public class DataSourceModel
    {
        public string URL { get; set; }
        public HttpMethodType Method { get; set; }
        public bool Paging { get; set; }
        public string Data { get; set; }
        public bool ServerSide { get; set; }
    }

    public enum HttpMethodType
    {
        GET,
        POST
    }
}
