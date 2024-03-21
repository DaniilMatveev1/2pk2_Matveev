using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    internal class Invoice
    {
        // поля класса
        private string period;
        private string clientName;
        private long codeOfInvoice;
        private double summ;
        private string adr;

        // конструкторы класса
        public Invoice(string period, string clientName, long codeOfInvoice, double summ, string adr)
        {
            this.period = period;
            this.clientName = clientName;
            this.codeOfInvoice = codeOfInvoice;
            this.summ = summ;
            this.adr = adr;
        }

        public Invoice(string period, string clientName, long codeOfInvoice)
            : this(period, clientName, codeOfInvoice, 0, "")
        {
        }

        public Invoice()
            : this("", "", 0, 0, "")
        {
        }
        public void GetInvoiceInf()
        {
            Console.WriteLine($"Получатель: {clientName}");
            Console.WriteLine($"Период: {period}");
            Console.WriteLine($"Счет №: {codeOfInvoice}");
            Console.WriteLine($"Сумма: {summ}");
            Console.WriteLine($"Адрес: {adr}");
        }
    }
}



