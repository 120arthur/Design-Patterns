using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bilder
{
    class InoviceBilder
    {
        private string SocialReason { get; set; }
        private string Cnpj { get; set; }
        private float GrossAmount { get; set; }
        private float Tax { get; set; }
        private DateTime Dateissue { get; set; }
        private string Comments { get; set; }

        private List<ListItem> ListItems = new List<ListItem>();

        public Inovice Bild()
        {
            return new Inovice(SocialReason, Cnpj, GrossAmount, Tax, Dateissue, Comments, ListItems);
        }

        public InoviceBilder InoviceSocialReason(string socialReason)
        {
            SocialReason = socialReason;
            return this;
        }

        public InoviceBilder InoviceCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public InoviceBilder InoviceDateissue()
        {
            Dateissue = DateTime.Now;
            return this;
        }

        public InoviceBilder InoviceComments(string comments)
        {
            Comments = comments;
            return this;
        }

        public InoviceBilder InoviceAddItem(ListItem listItem)
        {
            ListItems.Add(listItem);
            GrossAmount += listItem.Value;
            Tax = listItem.Value * 0.05f;
            return this;
        }


    }
}
