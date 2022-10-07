namespace ShoppingApp.Models {
    class Item {
        int price;
        string description;
        string uniqueid;

        public Item(int price = 0, string description = "Unknown", string uniqueid = "00000000") {
            this.price = price;
            this.description = description;
            this.uniqueid = uniqueid;
        }
    } 
}