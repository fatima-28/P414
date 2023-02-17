"use strict"
// 2 callback ve array qebul eden functionunuz var. 
// studentlerinizi funskiyaya gonderende, studentlerin adini uppercase eden
// ve yasi 18 den boyukdurse yasi, kicikdirse yasi 18 edib qaytaran metodlar yazin
//  ve netice consolede gorunsun
let stu1 = {
  name: "Fatima",
  age: 20,
};

let stu2 = {
  name: "Mahir",
  age: 20,
};

let stu3 = {
  name: "Resul",
  age: 15,
};
let stu4 = {
  name: "Murad",
  age: 18,
};
let stu5 = {
  name: "Nicat",
  age: 21,
};
 let students = [stu1, stu2, stu3,stu4,stu5];

 function GetStudents(arr,callback1,callback2) {
     for (const item of arr) {
         for (const key in item) {
           if (key=="name") {
              console.log( callback1(item[key]));
              
           }
           if (key == "age") {
                console.log( callback2(item[key]));
               
           }         
         }
        
     }
 }

  let GetUpperCaseName =(str) =>str.toUpperCase();
  
 function CheckAge(age) {
     if (age>18) {
         return age;
     }
     else{
         return 18;
     }
 }
 GetStudents(students,GetUpperCaseName,CheckAge)