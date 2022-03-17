Console.OutputEncoding = System.Text.Encoding.UTF8;
Account acc1 = new Account(72354,"Ted Murphy",102.56);
Account acc2 = new Account(69713,"Jane Smith",40.00);
Account acc3 = new Account(93757,"Edward Demsey",759.32);

acc1.Deposit();
acc2.Deposit();
acc2.Withdraw();
acc3.AddInterest();


Account.Title();
System.Console.WriteLine(acc1);
System.Console.WriteLine(acc2);
System.Console.WriteLine(acc3);
Account.line();

acc2.Tranfer(ref acc1,100.00);

Account.Title();
System.Console.WriteLine(acc1);
System.Console.WriteLine(acc2);
System.Console.WriteLine(acc3);
Account.line();