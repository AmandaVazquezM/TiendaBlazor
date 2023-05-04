// CartService.cs
using System.Collections.Generic;
using TiendaBlazor.Models;

namespace TiendaBlazor.Services
{
    public class CartService
    {
        public List<CartItem> CartItems { get; } = new List<CartItem>();

        // Agrega un producto al carrito de compras
        public void AddToCart(Product product)
        {
            // Buscar si el producto ya está en el carrito
            var existingCartItem = CartItems.Find(item => item.Product.Id == product.Id);

            if (existingCartItem != null)
            {
                // Si el producto ya está en el carrito, incrementar la cantidad
                existingCartItem.Quantity++;
            }
            else
            {
                // Si el producto no está en el carrito, agregar un nuevo item al carrito
                var newCartItem = new CartItem { Product = product, Quantity = 1 };
                CartItems.Add(newCartItem);
            }
        }

        public void RemoveFromCart(Product product)
        {
            // Buscar el item del carrito correspondiente al producto a eliminar
            var itemToRemove = CartItems.Find(item => item.Product.Id == product.Id);

            if (itemToRemove != null)
            {
                if (itemToRemove.Quantity > 1)
                {
                    // Si la cantidad es mayor a 1, disminuir la cantidad
                    itemToRemove.Quantity--;
                }
                else
                {
                    // Si la cantidad es 1, remover el item del carrito
                    CartItems.Remove(itemToRemove);
                }
            }
        }

        // Obtiene la cantidad total de precio de los productos en el carrito de compras
        public decimal GetTotalItemCount()
        {
            decimal total = 0;
            foreach (var item in CartItems)
            {
                total += item.Product.Price * item.Quantity;
            }
            return total;
        }

        // Obtiene la lista de items en el carrito de compras
        public List<CartItem> GetCartItems()
        {
            return CartItems;
        }
    }
}
