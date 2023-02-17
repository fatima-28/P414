//   Promtdan  classname ve capacity daxil edirsiz.
//    capacity reqem olmalidir. Deyilse uygun bildirish cixarin.
// Eger reqemdirse daxil 
// etdiyiniz reqem qeder stuname teleb edirsiz promt vastesile.
//     en sonda butun telebelerin adlarini consola cixaririsniz.
let className=prompt("Enter class name");
let capacity=prompt("Enter capacity");
let students=[];
if (!isNaN(capacity)) {
    AddStu(capacity);
}
else{
   alert("Capacity must be number")
}
ShowStudents(students);


function AddStu(capacity) {
    for (let i = 0; i < capacity; i++) {
      let stuName = prompt("Enter student name");
      students.push(stuName);
    }
}
function ShowStudents(arr) {
    for (let i = 0; i < arr.length; i++) {
      console.log(arr[i]);
    }
}