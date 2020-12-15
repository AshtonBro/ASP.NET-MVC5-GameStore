using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.WebUI.Models
{
    /// <summary>
    /// Класс содержит информацию о количестве доступных страниц, текущей странице и общем количестве товаров в хранилище. 
    /// </summary>
    public class PagingInfo
    {
        /// <summary>
        ///  Кол-во товаров
        /// </summary>
        public int TotalItems { get; set; }
        /// <summary>
        /// Кол-во товаров на одной странице
        /// </summary>
        public int ItemsPages { get; set; }
        /// <summary>
        /// Номер текущей страницы
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// Общее кол-во страниц
        /// </summary>
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPages); 
            }
        }
    }
}