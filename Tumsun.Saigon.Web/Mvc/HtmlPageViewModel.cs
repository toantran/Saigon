using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Tumsun.Saigon.Web.Mvc
{
    public class HtmlPageViewModel
    {
        /// <summary>
        /// Get or set the title of the page
        /// </summary>
        [ScaffoldColumn(false)]
        public string Title { get; set; }


        /// <summary>
        /// Gets or sets the keywords of the page
        /// </summary>
        [ScaffoldColumn(false)]
        public string KeyWords { get; set; }


        /// <summary>
        /// Gets or sets the Description of the page
        /// </summary>
        [ScaffoldColumn(false)]
        public string Description { get; set; }
    }
}
