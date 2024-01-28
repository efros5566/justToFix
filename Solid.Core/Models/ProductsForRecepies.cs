using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace project_Riki_Mittelman.Entities
{
    public class ProductsForRecepies
    {
        public int ProductsId { get; set; }

        public int RecepiesId { get; set; }

        public Products Products { get; set; }

        public Recepies Recepies { get; set; }

        public string Amount { get; set; }
    }
}
