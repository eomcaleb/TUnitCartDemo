namespace ShoppingApp.Models {
    class Cart {
        // Maximum items in cart
        static readonly uint MAX = 100; 
        Item[] cart = new Item[MAX];

        enum CODES {
            UNKNOWNERROR = -1,
            MAXITEMS,
            EMPTYCART,
            SUCCESS,
        }

        int top;
        // Constructor: set the default top value to -1
        public Cart() {this.top = -1;}

        int AddItem(Item item) {
            if (this.top >= this.MAX) {
                return (int)CODES.MAXITEMS;
            }
            else {
                cart[++top] = item;
                return (int)CODES.SUCCESS;
            }
        }

        int RemoveItem() {
            if (this.top < 0) {
                return (int)CODES.EMPTYCART;
            }
            else {
                this.cart[top--];
                return (int)CODES.SUCCESS;
            }
        }

        void PrintCartContent () {
            foreach(int i = top; i >= 0; i--) {
                Console.WriteLine(cart[i].description + "|" + cart[i].price + "|" + cart[i].uniqueid);
            }
        }

    }
}