var pName = [];
var pMeasurement = [];
var pQty = [];
var pPrice = [];
var subTotal = [];
var methods = document.querySelectorAll(".method");

function addItem(){
	var product = document.getElementById("product");
	var measure = document.querySelector("#measure");
	var quantity = document.querySelector("#quantity");
	var price =  document.querySelector("#price");
	pName.push(product.value);
	pMeasurement.push(measure.value);
	pQty.push(quantity.value);
	pPrice.push(price.value);
	displayCart();
	product.value = "";
	measure.value = "";
	quantity.value = "";
	price.value = "";
}

function displayCart(){
	cartdata =	
	"<table><tr><button onclick= 'sort()'>Sort By Product Name</button><th>Product Name</th><th>Unit of Measure</th><th>Quantity</th><th>Price</th><th>Subtotal</th><button onclick= 'subtotalSort()'>Sort By Subtotal</button></tr>"
var total = 0;
for(i=0; i < pName.length; i++){
	subTotal[i] = pQty[i] * pPrice[i];
	total += subTotal[i];
	cartdata += "<tr><td>" + pName[i] + 
	"</td><td>" + pMeasurement[i] +
	"</td><td>" + pQty[i] + 
	"</td><td>" + pPrice[i] + 
	"</td><td>" + subTotal[i] + 
 "</td><td><button onclick= 'remItem(" + i + ")'>Remove</button></td></tr>"
}
 cartdata +="<tr><td></td><td></td><td></td><td></td><td>" + total + "</td></tr></table>"
  document.getElementById("shoppingCart").innerHTML = cartdata;
   
 }
 function sort(){
	 pName.sort();
	 displayCart();
 }
  function subtotalSort(){
    subTotal.sort();
	displayCart();
 }

 function remItem(p){
	 pName.splice(p,1);
	 pMeasurement.splice(p,1);
	 pQty.splice(p,1);
	 pPrice.splice(p,1);
	 displayCart();
 }
 var completed = document.querySelector("#summit");
 completed.addEventListener("click",function(){
	 alert("Your Order is completed!")
 })


