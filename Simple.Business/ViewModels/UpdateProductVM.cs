using Microsoft.AspNetCore.Http;
using Simple.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Business.ViewModels
{
    public class UpdateProductVM  : BaseEntity
    {
        public IFormFile Imgage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
