// A reusable block of code that calculates a value
function calculateTotal(price, taxRate) {
  return price + (price * taxRate);
}

// Calling the function
const finalAmount = calculateTotal(100, 0.05); 

console.log(finalAmount); // Outputs: 105












