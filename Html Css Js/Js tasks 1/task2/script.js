
// Array var, arraydaki elementlerimin reqem olub olmadigini yoxlayin. Eger reqemdirse ve
//  3 e bolunurse hemin ededleri bir stringe yigib alertle cixarin,eyni zamanda arrayin butun
//  elemetleri console cixsin. Seliqeli funskyalar ile yazin
"use strict";

let arr = [5, 8, 0, 12, 23, 43, 75, 34, 5, 9, "7", "8", "dbsakdbsjab"];
let nums = "";

for (let i = 0; i < arr.length; i++) {
  if (typeof arr[i] == "number" && checkDivisionByThree(arr[i])) {
    nums += arr[i] + " ";
  }
  console.log(arr[i]);
}

function checkDivisionByThree(num) {
  if (num % 3 == 0) {
    return true;
  } else {
    return false;
  }
}

alert(nums);

