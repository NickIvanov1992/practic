CreditCard card = new CreditCard();
Client client = new Client();
card.delegateRegister(client.Method1);                                             // делегат
card.Put(50);
card.Get(150);

card.delegateRegister(delegate (string str) { Console.WriteLine(str); });      //аноним метод
card.Put(200);
card.Get(300);

card.delegateRegister(str => Console.WriteLine(str));                      // лямбда
card.Put(400);
card.Get(5000);


card.action += client.Method1;                                            // событие
card.Put(10);
card.Get(1000000);

