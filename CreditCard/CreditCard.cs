using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





    public class CreditCard
    {
        public delegate void AccountAction(string str);
        AccountAction? givemoney;
        public event AccountAction? action;

        public void delegateRegister(AccountAction del) => givemoney = del;

        public void Put(int money)
        {
           
            givemoney?.Invoke($"Положить деньги :{money}");
            action?.Invoke($"Событие Положить деньги  :{money}");
        }

        public void Get(int money)
        {
            
                givemoney?.Invoke($"Снять деньги :{money}");
                action?.Invoke($"Событие: Снять деньги :{money}");
    }
           
        }
    

