using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Items
    {
        //Name string
        private string itemTitle;

        //Description of item.
        private string itemDescription;

        //item weight
        private int weight = 1;

        #region properties

        public string ItemTitle
        {
            get { return itemTitle; }
            set { itemTitle = value; }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        #endregion


    }
}
