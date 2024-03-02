//task2 random 

    var names = ["dina" , "merna" , "salma", "mohamed", "mustafa", "mahmoud", "rana" , "omar"];
    function getRandom(min , max){
        return Math.floor(Math.random() * (max - min + 1)) + min ;
    }
    var name1= names[ getRandom(0,names.length - 1)];
    var name2 =names[ getRandom(0,names.length - 1)];
    arr = [name1]
    function getRanNames(){
        do{
            arr.push(name2) ;
            return arr;

        }
        while(name1 != name2 )
 
     }
        document.write(getRanNames());

//task1
do {
    UserName = prompt("First Name ");
    }while(UserName==null || UserName.trim().length==0  || !isNaN(Number(UserName.substring(0))))
    
    do{
    PhoneNumber = prompt("Phone Number ");
    }while(PhoneNumber == null ||
          PhoneNumber.trim().length !== 12 ||
         (PhoneNumber.substring(0, 3) !== "010" &&
         PhoneNumber.substring(0, 3) !== "011" &&
         PhoneNumber.substring(0, 3) !== "012" &&
         PhoneNumber.substring(0, 3) !== "015") ||
         PhoneNumber.charAt(3)!=="-" 
        ||isNaN(Number(PhoneNumber.substring(4,PhoneNumber.length))));
        console.log("phone number = " + PhoneNumber)