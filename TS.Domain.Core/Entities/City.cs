namespace TS.Domain.Core.Entities
{
    public class City 
    {
        #region Properties

        public int Id { get; set; }
        public string? Name { get; set; }

        #endregion Properties

        #region Navigation properties

        public List<Address>? Customers { get; set; }

        #endregion Navigation properties

    }
}
