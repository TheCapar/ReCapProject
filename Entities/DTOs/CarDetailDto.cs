using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public string CarName { get; set; }
        public int DailyPrice { get; set; }
        public int KolorId { get; set; }
        public string KolorName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        
    }
}
