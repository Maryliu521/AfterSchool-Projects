
var toDoList = [];
while(userType !== "quit"){
	var userType = prompt("What you want to do now?")
   if(userType ==="new"){
	addToDo();
   }
   else if (userType ==="list"){
	listToDo();
	}
   else if (userType ==="delete"){
	deleteTodo();
    }

}
console.log("OK, You quit!")
function addToDo(){
	userType=prompt("Add new...")
	toDoList.push(userType);
}
function listToDo(){
	for(i=0; i<toDoList.length; i++){
		console.log("*******");
		console.log(i +": " +toDoList[i]);
		console.log("*******");
		}
}
function deleteTodo(){
	var num = prompt("Please type the correct index number!")
	toDoList.splice(num,1);
}