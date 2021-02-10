using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bilder
{
    public class Inovice
    {
        public string SocialReason { get; set; }
        public string Cnpj { get; set; }
        public float GrossAmount { get; set; }
        public float Tax { get; set; }
        public DateTime Dateissue { get; set; }
        public string Comments { get; set; }
        public List<ListItem> listItems = new List<ListItem>();

        public Inovice(string socialReason, string cnpj, float grossAmount, float tax, DateTime dateissue, string comments, List<ListItem> listItems)
        {
            SocialReason = socialReason;
            Cnpj = cnpj;
            GrossAmount = grossAmount;
            Tax = tax;
            Dateissue = dateissue;
            Comments = comments;
            this.listItems = listItems;
        }
    }
}
