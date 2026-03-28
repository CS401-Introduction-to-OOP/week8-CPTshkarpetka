namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> Items = new();

    public void AddItem(T item)
    {
        Items.Add(item);
    }

    public double GetTotalCost()
    {
        return Items.Sum(item => item.CalculateCost());
    }
}