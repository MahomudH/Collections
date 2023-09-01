namespace Collections.HashSetAndSortedSetApp
{
    public class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + Phone.GetHashCode();

            return hash;
        }

        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if (customer is null)
                return false;

            return this.Phone.Equals(customer.Phone);
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            if (customer1 is null || customer2 is null)
                return false;

            return customer1.Phone.Equals(customer2.Phone);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            if (customer1 is null || customer2 is null)
                return false;

            return !customer1.Phone.Equals(customer2.Phone);
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Phone})";
        }

        public int CompareTo(Customer other)
        {
            if(object.ReferenceEquals(this, other)) return 0 ;
            if(other is null) return -1 ;
            return this.Name.CompareTo(other.Name); 
        }
    }
}
