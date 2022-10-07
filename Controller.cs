namespace ShoppingCart.Controller {
    public class ShoppingController : ApiController
    {
        Cart cart = new Cart();
        
        public IEnumerable<Cart> ListAllItems()
        {
            this.cart.PrintCartContent();
        }

        public IHttpActionResult AddItem(Item i) {
            return this.cart.AddItem(i);
        }
        
        public IHttpActionResult RemoveItem() {
            return this.cart.RemoveItem();
        }
    }

}