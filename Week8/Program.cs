using Week8;

DeliveryItem letter1 = new Letter("letter1", 100);
DeliveryItem letter2 = new Letter("letter2", 10);
DeliveryItem parcel1 = new Parcel("parcel1", 5, "10x10x50");
DeliveryItem parcel2 = new Parcel("parcel2", 10, "10x20x30");

letter1.PrintInfo();
letter2.PrintInfo();
parcel1.PrintInfo();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);

Console.WriteLine($"Total cost: {myCargo.GetTotalCost()}");