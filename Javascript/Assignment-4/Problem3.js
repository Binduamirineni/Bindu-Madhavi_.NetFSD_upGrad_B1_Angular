let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];


let total = cart.reduce((sum, item) => sum + item.price * item.qty, 0);
console.log("Total cart value: ", total);

let updatedCart = cart.map(item => {
  if (item.id === 2) {
    item.qty += 1;
  }
  return item;
});
console.log(updatedCart);


let newCart = cart.filter(item => item.id !== 3);
console.log(newCart);

let discountCart = cart.map(item => {
  if (item.price > 10000) {
    item.price = item.price * 0.9;
  }
  return item;
});
console.log(discountCart);


let sortedCart = cart.sort((a, b) => 
  (a.price * a.qty) - (b.price * b.qty)
);
console.log(sortedCart);

let hasExpensive = cart.some(item => item.price > 50000);
console.log(hasExpensive);


let inStock = cart.every(item => item.qty > 0);
console.log(inStock);
