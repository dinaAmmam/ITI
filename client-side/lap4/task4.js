//task1
do{
    msg = prompt("enter a message");
    for( i =1; i<7; i++){
        document.write("<h"+i+">"+msg+"</h"+i+">");
    }
} while(!isNaN(msg)); 

//task2
var sum = 0;
do{
    num = prompt("enter number");
        sum += Number(num);
}while (Number(num)%1 != 0 || sum < 100 || Number(num) == 0 )
console.log("sum ="+ sum)

