using Microsoft.DotNetCore.Hosting.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TransactionFormViewModel : BaseViewModel
    {
        private bool barEnabled = true;
        public bool BarEnabled
        {
            get { return barEnabled; }
            set { SetProperty(ref barEnabled, value); }
        }

        private bool formEnabled = true;
        public bool FormEnabled
        {
            get { return formEnabled; }
            set { SetProperty(ref formEnabled, value); }
        }

        private long amount;
        public long Amount
        {
            get { return amount; }
            set { SetProperty(ref amount, value); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }

        private decimal total;
        public decimal Total
        {
            get { return total; }
            set { SetProperty(ref total, value); }
        }
    }
}